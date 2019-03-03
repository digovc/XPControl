using FMUtils.KeyboardHook;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPControl
{
    internal abstract class Input
    {
        internal static bool Control;
        internal static float PositionHeading;
        internal static float PositionPitch;
        internal static float PositionRoll;
        internal static float SensibilityHeading = .75f;
        internal static float SensibilityPitch = .75f;
        internal static float SensibilityRoll = .75f;
        internal static bool Shift;
        private static readonly int _halfHeight = Screen.PrimaryScreen.Bounds.Height / 2;
        private static readonly int _halfWidth = Screen.PrimaryScreen.Bounds.Width / 2;
        private static bool _calculing;
        private static Hook _hook = new Hook("XPControl");
        private static Point _lastPosition;
        private static bool _running;

        internal static async void StartAsync()
        {
            _running = true;

            await Task.Run(() =>
            {
                _hook.KeyUpEvent += KeyUpEvent;
            });
        }

        internal static async void StopAsync()
        {
            await Task.Run(() =>
            {
                _running = false;

                _hook.KeyUpEvent -= KeyUpEvent;
            });
        }

        private static async void CalculateAsync()
        {
            if (_calculing)
            {
                return;
            }

            _calculing = true;

            Console.WriteLine("Calculating");

            if (!_running)
            {
                StopAsync();
                return;
            }

            await Task.Run(() =>
            {
                while (_running && (Control || Shift))
                {
                    CalculateLoop();

                    Thread.Sleep(50);
                }
            });

            _calculing = false;
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

        private static void CalculateLoop()
        {
            var position = Cursor.Position;

            if (position.X != _lastPosition.X || position.Y != _lastPosition.Y)
            {
                PositionHeading = CalculateHeading(position.X, _halfWidth, SensibilityHeading);
                PositionRoll = CalculateHeading(position.X, _halfWidth, SensibilityRoll);
                PositionPitch = CalculateHeading(position.Y, _halfHeight, SensibilityPitch);

                _lastPosition = position;
            }
        }

        private static void KeyUpEvent(KeyboardHookEventArgs e)
        {
            if (!_running)
            {
                StopAsync();
                return;
            }

            if (e.isCtrlPressed)
            {
                Control = !Control;
            }

            if (e.isShiftPressed)
            {
                Shift = !Shift;
            }

            if (Control || Shift)
            {
                CalculateAsync();

                XPlane.SendInputAsync();
            }
        }
    }
}