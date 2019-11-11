using Gma.System.MouseKeyHook;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPControl
{
    internal abstract class Input
    {
        internal static bool Heading;
        internal static float PositionHeading;
        internal static float PositionPitch;
        internal static float PositionRoll;
        internal static float SensibilityHeading = .75f;
        internal static float SensibilityPitch = .75f;
        internal static float SensibilityRoll = .75f;
        internal static bool Yoke;
        private static readonly int _halfHeight = Screen.PrimaryScreen.Bounds.Height / 2;
        private static readonly int _halfWidth = Screen.PrimaryScreen.Bounds.Width / 2;
        private static Point _lastPosition;

        internal static async void StartAsync()
        {
            await Task.Run(() =>
            {
                Hook.GlobalEvents().MouseClick += MouseClick;
            });
        }

        internal static async void StopAsync()
        {
            await Task.Run(() =>
            {
                Hook.GlobalEvents().MouseClick -= MouseClick;
            });
        }

        private static void Calculate()
        {
            Console.WriteLine("Calculating");

            var position = Cursor.Position;

            if (position.X != _lastPosition.X || position.Y != _lastPosition.Y)
            {
                PositionHeading = CalculateHeading(position.X, _halfWidth, SensibilityHeading);
                PositionRoll = CalculateHeading(position.X, _halfWidth, SensibilityRoll);
                PositionPitch = CalculateHeading(position.Y, _halfHeight, SensibilityPitch);
                _lastPosition = position;
            }
        }

        private static float CalculateHeading(int actualPosition, int half, float sensibility)
        {
            if (actualPosition > half)
            {
                return Math.Min((float)(actualPosition - half) / half * sensibility, 1);
            }
            else if (actualPosition < half)
            {
                return Math.Min((float)(half - actualPosition) / half * sensibility, 1) * -1;
            }
            else
            {
                return 0;
            }
        }

        private static void MouseClick(object sender, MouseEventArgs e)
        {
            if (Heading && e.Button == MouseButtons.XButton2)
            {
                XPlane.ResetHeading();
            }

            if (e.Button == MouseButtons.XButton2)
            {
                Heading = !Heading;
            }

            if (e.Button == MouseButtons.XButton1)
            {
                Yoke = !Yoke;
            }

            if (Heading || Yoke)
            {
                StartMouseMonitor();
            }
            else
            {
                StopMouseMonitor();
            }
        }

        private static void MouseMove(object sender, MouseEventArgs e)
        {
            if (Heading || Yoke)
            {
                Calculate();
                XPlane.SendInput();
            }
            else
            {
                StopMouseMonitor();
            }
        }

        private static void MouseWheel(object sender, MouseEventArgs e)
        {
            if (Heading || Yoke)
            {
                XPlane.ChangeThrottle(e.Delta * .01);
            }
        }

        private static void StartMouseMonitor()
        {
            Hook.GlobalEvents().MouseMove += MouseMove;
            Hook.GlobalEvents().MouseWheel += MouseWheel;
        }

        private static void StopMouseMonitor()
        {
            Hook.GlobalEvents().MouseMove -= MouseMove;
            Hook.GlobalEvents().MouseWheel -= MouseWheel;
        }
    }
}