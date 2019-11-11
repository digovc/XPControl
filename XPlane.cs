using System;
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

        internal static void ChangeThrottle(short delta)
        {
            var command = XPlaneConnector.Commands.EnginesThrottleUp;

            if (delta < 0)
            {
                command = XPlaneConnector.Commands.EnginesThrottleDown;
            }

            for (int i = 0; i < Math.Abs(delta); i++)
            {
                _connector.SendCommand(command);
            }
        }

        internal static void ResetHeading()
        {
            SendDataRef("sim/joystick/yoke_heading_ratio", 0);
        }

        internal static void SendInput()
        {
            if (_running)
            {
                SendInputs();
            }
            else
            {
                StopAsync();
            }
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
                SendDataRef("sim/operation/override/override_joystick", 0);
                _connector.Stop();
                _running = false;
            });
        }

        private static void SendDataRef(string name, float value)
        {
            _connector.SetDataRefValue(name, value);
            Console.WriteLine($"Sending: {name} {value}");
        }

        private static void SendInputHeading()
        {
            if (Input.Heading && _lastPositionHeading != Input.PositionHeading)
            {
                SendDataRef("sim/joystick/yoke_heading_ratio", Input.PositionHeading);
                _lastPositionHeading = Input.PositionHeading;
            }
        }

        private static void SendInputPitch()
        {
            if (Input.Yoke && _lastPositionPitch != Input.PositionPitch)
            {
                SendDataRef("sim/joystick/yoke_pitch_ratio", Input.PositionPitch);
                _lastPositionPitch = Input.PositionPitch;
            }
        }

        private static void SendInputRoll()
        {
            if (Input.Yoke && _lastPositionRoll != Input.PositionRoll)
            {
                SendDataRef("sim/joystick/yoke_roll_ratio", Input.PositionRoll);
                _lastPositionRoll = Input.PositionRoll;
            }
        }

        private static void SendInputs()
        {
            SendInputHeading();
            SendInputRoll();
            SendInputPitch();
        }
    }
}