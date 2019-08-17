using System;
using Windows.Devices.Geolocation;
using Windows.Devices.Sensors;

namespace WinFormsCarTools.Sensors
{
    public class SensorReadingChangedEventArgs : EventArgs
    {
        public SensorReadingChangedEventArgs(SensorEventReason eventReason)
        {
            SensorEventReason = eventReason;
        }

        public SensorEventReason SensorEventReason { get; private set; }

        public GyrometerReading GyrometerReading { get; set; }

        public AccelerometerReading AccelerometerReading { get; set; }

        public PositionStatus PositionStatus { get; set; }

        public Geoposition Geoposition { get; set; }
    }
}
