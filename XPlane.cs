using System;
using System.Threading;
using System.Threading.Tasks;

namespace XPControl
{
    internal static class XPlane
    {
        private static XPlaneConnector.XPlaneConnector _connector = new XPlaneConnector.XPlaneConnector();

        private static float _lastPositionHeading;
        private static float _lastPositionPitch;
        private static float _lastPositionRoll;
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

                SendDataRef("sim/operation/override/override_joystick", 1);
            });
        }

        internal static async void StopAsync()
        {
            await Task.Run(() =>
            {
                SendDataRef("sim/joystick/yoke_heading_ratio", 0);
                SendDataRef("sim/operation/override/override_joystick", 0);

                _connector.Stop();
            });
        }

        private static void SendDataRef(string name, float value)
        {
            _connector.SetDataRefValue(name, value);
            Console.WriteLine($"Sending: {name} {value}");
        }

        private static void SendInputLoop()
        {
            SendInputLoopHeading();

            SendInputLoopRoll();

            SendInputLoopPitch();
        }

        private static void SendInputLoopHeading()
        {
            if (Input.Control && _lastPositionHeading != Input.PositionHeading)
            {
                SendDataRef("sim/joystick/yoke_heading_ratio", Input.PositionHeading);
                _lastPositionHeading = Input.PositionHeading;
            }
        }

        private static void SendInputLoopPitch()
        {
            if (Input.Shift && _lastPositionPitch != Input.PositionPitch)
            {
                SendDataRef("sim/joystick/yoke_pitch_ratio", Input.PositionPitch);
                _lastPositionPitch = Input.PositionPitch;
            }
        }

        private static void SendInputLoopRoll()
        {
            if (Input.Shift && _lastPositionRoll != Input.PositionRoll)
            {
                SendDataRef("sim/joystick/yoke_roll_ratio", Input.PositionRoll);
                _lastPositionRoll = Input.PositionRoll;
            }
        }
    }
}