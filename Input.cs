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
        internal static double MovementX;
        internal static double MovementY;
        private static bool _control;
        private static Hook _hook = new Hook("XPControl");
        private static Point _lastPosition;
        private static bool _shift;
        private static Point _startPosition;

        internal static async void InitializeAsync()
        {
            await Task.Run(() =>
            {
                _hook.KeyDownEvent += KeyDownEvent;
                _hook.KeyUpEvent += KeyUpEvent;
            });
        }

        private static async void CalculateAsync()
        {
            await Task.Run(() =>
            {
                while (_control || _shift)
                {
                    var position = Cursor.Position;

                    if (position.X != _lastPosition.X || position.Y != _lastPosition.Y)
                    {
                        MovementX = (double)(position.X - _startPosition.X) / Screen.PrimaryScreen.Bounds.Width;
                        MovementY = (double)(position.Y - _startPosition.Y) / Screen.PrimaryScreen.Bounds.Height;

                        _lastPosition = position;

                        Console.WriteLine(MovementX + "x" + MovementY);
                    }

                    Thread.Sleep(15);
                }
            });
        }

        private static void KeyDownEvent(KeyboardHookEventArgs e)
        {
            if (_control || _shift)
            {
                return;
            }

            _control = e.isCtrlPressed;
            _shift = e.isShiftPressed;

            if (_control || _shift)
            {
                _startPosition = Cursor.Position;
                _lastPosition = Cursor.Position;

                CalculateAsync();

                Console.WriteLine("started");
            }
        }

        private static void KeyUpEvent(KeyboardHookEventArgs e)
        {
            _control = false;
            _shift = false;

            MovementX = 0;
            MovementY = 0;
            Console.WriteLine("stopped");
        }
    }
}