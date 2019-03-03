using System.Threading;
using System.Threading.Tasks;

namespace XPControl
{
    internal static class XPlane
    {
        private static XPlaneConnector.XPlaneConnector _connector = new XPlaneConnector.XPlaneConnector();

        private static float _lastPOsitionControlX;
        private static float _lastPOsitionShiftX;
        private static float _lastPOsitionY;

        internal static async void InitializeAsync()
        {
            await Task.Run(() =>
            {
                _connector.Start();

                _connector.SetDataRefValue("sim/operation/override/override_joystick", 1);
            });
        }

        internal static async void SendInputAsync()
        {
            await Task.Run(() =>
            {
                while (Input.Control || Input.Shift)
                {
                    if (Input.Control && _lastPOsitionControlX != Input.PositionX)
                    {
                        _connector.SetDataRefValue("sim/joystick/yoke_heading_ratio", Input.PositionX);
                        _lastPOsitionControlX = Input.PositionX;
                    }

                    if (Input.Shift && _lastPOsitionShiftX != Input.PositionX)
                    {
                        _connector.SetDataRefValue("sim/joystick/yoke_roll_ratio", Input.PositionX);
                        _lastPOsitionShiftX = Input.PositionX;
                    }

                    if (Input.Shift && _lastPOsitionY != Input.PositionY)
                    {
                        _connector.SetDataRefValue("sim/joystick/yoke_pitch_ratio", Input.PositionY);
                        _lastPOsitionY = Input.PositionY;
                    }

                    Thread.Sleep(50);
                }
            });
        }
    }
}