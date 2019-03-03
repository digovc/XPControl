using System.Threading;
using System.Threading.Tasks;

namespace XPControl
{
    internal static class XPlane
    {
        private static XPlaneConnector.XPlaneConnector _connector = new XPlaneConnector.XPlaneConnector();

        private static float _lastPositionControlX;
        private static float _lastPositionShiftX;
        private static float _lastPositionY;
        private static bool _running;

        internal static async void SendInputAsync()
        {
            if (!_running)
            {
                StopAsync();
                return;
            }

            await Task.Run(() =>
            {
                while (Input.Control || Input.Shift)
                {
                    SendInputLoop();

                    Thread.Sleep(50);
                }
            });
        }

        internal static async void StartAsync()
        {
            await Task.Run(() =>
            {
                _running = true;

                _connector.Start();

                _connector.SetDataRefValue("sim/operation/override/override_joystick", 1);
            });
        }

        internal static async void StopAsync()
        {
            await Task.Run(() =>
            {
                _connector.SetDataRefValue("sim/operation/override/override_joystick", 0);

                _connector.Stop();
            });
        }

        private static void SendInputLoop()
        {
            SendInputLoopHeading();

            SendInputLoopRoll();

            SendInputLoopPitch();
        }

        private static void SendInputLoopHeading()
        {
            if (Input.Control && _lastPositionControlX != Input.PositionX)
            {
                _connector.SetDataRefValue("sim/joystick/yoke_heading_ratio", Input.PositionX);
                _lastPositionControlX = Input.PositionX;
            }
        }

        private static void SendInputLoopPitch()
        {
            if (Input.Shift && _lastPositionY != Input.PositionY)
            {
                _connector.SetDataRefValue("sim/joystick/yoke_pitch_ratio", Input.PositionY);
                _lastPositionY = Input.PositionY;
            }
        }

        private static void SendInputLoopRoll()
        {
            if (Input.Shift && _lastPositionShiftX != Input.PositionX)
            {
                _connector.SetDataRefValue("sim/joystick/yoke_roll_ratio", Input.PositionX);
                _lastPositionShiftX = Input.PositionX;
            }
        }
    }
}