using FMUtils.KeyboardHook;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPControl
{
    internal abstract class Input
    {
        internal static bool Control;
        internal static float PositionX;
        internal static float PositionY;
        internal static bool Shift;

        private static bool _calculing;
        private static Hook _hook = new Hook("XPControl");
        private static Point _lastPosition;
        private static bool _running;

        internal static async void StartAsync()
        {
            _running = true;

            await Task.Run(() =>
            {
                _hook.KeyDownEvent += KeyDownEvent;
                _hook.KeyUpEvent += KeyUpEvent;
            });
        }

        internal static async void StopAsync()
        {
            await Task.Run(() =>
            {
                _running = false;

                _hook.KeyDownEvent -= KeyDownEvent;
                _hook.KeyUpEvent -= KeyUpEvent;
            });
        }

        private static async void CalculateAsync()
        {
            if (!_running)
            {
                StopAsync();
                return;
            }

            await Task.Run(() =>
            {
                while (Control || Shift)
                {
                    var position = Cursor.Position;

                    if (position.X != _lastPosition.X || position.Y != _lastPosition.Y)
                    {
                        PositionX = (float)position.X / Screen.PrimaryScreen.Bounds.Width * 2f - 1f;
                        PositionY = (float)position.Y / Screen.PrimaryScreen.Bounds.Height * 2f - 1f;

                        _lastPosition = position;
                    }

                    Thread.Sleep(50);
                }
            });
        }

        private static void KeyDownEvent(KeyboardHookEventArgs e)
        {
            if (!_running)
            {
                StopAsync();
                return;
            }

            Control = e.isCtrlPressed;
            Shift = e.isShiftPressed;

            if (Control || Shift && !_calculing)
            {
                _calculing = true;

                CalculateAsync();

                XPlane.SendInputAsync();
            }
        }

        private static void KeyUpEvent(KeyboardHookEventArgs e)
        {
            if (!_running)
            {
                StopAsync();
                return;
            }

            if (Control && e.isCtrlPressed)
            {
                Control = false;
            }

            if (Shift && e.isShiftPressed)
            {
                Shift = false;
            }

            if (!Control && !Shift)
            {
                _calculing = false;
            }
        }
    }
}