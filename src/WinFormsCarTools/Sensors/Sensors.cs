﻿using System;
using Windows.Devices.Geolocation;
using Windows.Devices.Sensors;

namespace WinFormsCarTools.Sensors
{
    public class Sensors
    {
        public event EventHandler<SensorReadingChangedEventArgs> SensorReadingChanged;

        private Geolocator _locator;
        private Accelerometer _accelerometor;
        private Gyrometer _gyrometer;

        public Sensors()
        {
            _locator = new Geolocator
            {
                ReportInterval = 250
            };

            _locator.StatusChanged += Locator_StatusChanged;
            _locator.PositionChanged += Locator_PositionChanged;

            _accelerometor = Accelerometer.GetDefault(AccelerometerReadingType.Standard);
            if (_accelerometor != null)
            {
                _accelerometor.ReadingChanged += Accelerometor_ReadingChanged;
            }

            _gyrometer = Gyrometer.GetDefault();
            if (_gyrometer != null)
            {
                _gyrometer.ReadingChanged += _gyrometer_ReadingChanged;
            }
        }

        protected virtual void OnSensorReadingChanged(SensorReadingChangedEventArgs eArgs)
        {
            var readingChangedEvent = SensorReadingChanged;
            if (!(readingChangedEvent is null))
            {
                readingChangedEvent(this, eArgs);
            }
        }

        private void _gyrometer_ReadingChanged(Gyrometer sender, GyrometerReadingChangedEventArgs args)
        {
            OnSensorReadingChanged(new SensorReadingChangedEventArgs(SensorEventReason.Gyrometer)
            {
                 GyrometerReading=args.Reading
            });
        }

        private void Accelerometor_ReadingChanged(Accelerometer sender, AccelerometerReadingChangedEventArgs args)
        {
            OnSensorReadingChanged(new SensorReadingChangedEventArgs(SensorEventReason.Accelerometer)
            {
                AccelerometerReading = args.Reading
            });
        }

        private void Locator_StatusChanged(Geolocator sender, StatusChangedEventArgs args)
        {
            OnSensorReadingChanged(new SensorReadingChangedEventArgs(SensorEventReason.GpsStatus)
            {
                PositionStatus = args.Status
            });
        }

        private void Locator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            OnSensorReadingChanged(new SensorReadingChangedEventArgs(SensorEventReason.GpsPosition)
            {
                 Geoposition = args.Position
            });
        }
    }
}
