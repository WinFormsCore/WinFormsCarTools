using System;
using System.Windows.Forms;

namespace WinFormsCarTools
{
    public partial class MainForm : Form
    {

#if NETCOREAPP
        private WinFormsCarTools.Sensors.Sensors _sensors = new WinFormsCarTools.Sensors.Sensors();
#endif

        public MainForm()
        {
            InitializeComponent();
#if NETCOREAPP
            _sensors.SensorReadingChanged += Sensors_SensorReadingChanged;
#endif
    }

#if NETCOREAPP
        private void Sensors_SensorReadingChanged(object sender, Sensors.SensorReadingChangedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => Sensors_SensorReadingChanged(sender, e)));
                return;
            }

            switch (e.SensorEventReason)
            {
                case Sensors.SensorEventReason.Gyrometer:
                    {
                        gyroXLabel.Text = $"AVX: {e.GyrometerReading.AngularVelocityX:0.00}";
                        gyroYLabel.Text = $"AVX: {e.GyrometerReading.AngularVelocityY:0.00}";
                        gyroZLabel.Text = $"AVX: {e.GyrometerReading.AngularVelocityZ:0.00}";
                    }
                    break;

                case Sensors.SensorEventReason.Accelerometer:
                    break;

                case Sensors.SensorEventReason.GpsStatus:
                    break;

                case Sensors.SensorEventReason.GpsPosition:
                    gaugeControl1.Value = (float?)e.Geoposition.Coordinate.Speed ?? 0f;
                    break;
            }
        }
#endif
    }
}
