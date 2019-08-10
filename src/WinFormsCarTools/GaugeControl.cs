using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsCarTools
{
    class GaugeControl : Control
    {
        private float _value = 0;

        public GaugeControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            Font = new Font(Font.FontFamily, Font.Size * 1.5f, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(BackColor);

            //Create Brushes and Pens
            float penWidth = 3F;
            float halfPenWidth = penWidth / 2;

            var foreColorPen = new Pen(ForeColor, penWidth);
            var foreColorBrush = new SolidBrush(ForeColor);

            RectangleF closeSize = new RectangleF(
                halfPenWidth,
                halfPenWidth,
                (ClientSize.Width - 1) - penWidth,
                (ClientSize.Height - 1) - penWidth);

            PointF center = new PointF
            {
                X = ClientSize.Width / 2.0F,
                Y = ClientSize.Height / 2.0F
            };

            //Size minus edge of the clock.
            SizeF size = new SizeF
            {
                Width = (float)(closeSize.Width / 2.0),
                Height = (float)(closeSize.Height / 2.0)
            };

            //Outer dial circle
            g.DrawEllipse(foreColorPen, closeSize);

            //Draw the dial.
            float dialSteps = (MaxValue - MinValue) / SeperationStepValue;
            float angleStep = (GaugeEndAngle - GaugeStartAngle) / dialSteps;
            float currentUnitValue = MinValue;

            for (float angle = GaugeStartAngle; angle <= GaugeEndAngle; angle += angleStep)
            {
                // Draw unit separators.
                var effectiveAngle = (angle + DialOffsetAngle) % 360;
                var pcStart = new PolarCoordinate(center, size.Width, size.Height, effectiveAngle);
                var pcEnd = new PolarCoordinate(center, size.Width - DialLength, size.Height - DialLength, effectiveAngle);
                g.DrawLine(Pens.Black, pcStart.Cartesian.X, pcStart.Cartesian.Y, pcEnd.Cartesian.X, pcEnd.Cartesian.Y);

                // Draw unit texts.
                PolarCoordinate textPos = new PolarCoordinate(center, size.Width - UnitTextOffset, size.Height - UnitTextOffset, effectiveAngle);
                var currentUnitText = ((int)currentUnitValue).ToString();
                currentUnitValue += SeperationStepValue;
                var textExtends = g.MeasureString(currentUnitText, Font);

                var textHotSpotOffset = new SizeF(textExtends.Width / 2, textExtends.Height / 2);
                var textPosition = textPos.Cartesian - textHotSpotOffset;
                g.DrawString(currentUnitText, Font, foreColorBrush, textPosition);
            }

            // Draw value hand.
            var valueAngle = GaugeStartAngle + DialOffsetAngle + Value * angleStep;
            var handStart = new PolarCoordinate(center, size.Width - ValueHandStart, size.Height - ValueHandStart, valueAngle);
            var handEnd = new PolarCoordinate(center, size.Width - ValueHandEnd, size.Height - ValueHandEnd, valueAngle);
            g.DrawLine(foreColorPen, handStart.Cartesian.X, handStart.Cartesian.Y, handEnd.Cartesian.X, handEnd.Cartesian.Y);

            var centerEllipse = new SizeF(size.Width - ValueHandEnd - 5, size.Height - ValueHandEnd - 5);
            g.FillEllipse(foreColorBrush, new RectangleF(center - centerEllipse, centerEllipse + centerEllipse));
        }

        [DefaultValue(40), Category("Appearance")]
        public int GaugeStartAngle { get; set; } = 40;

        [DefaultValue(320), Category("Appearance")]
        public int GaugeEndAngle { get; set; } = 320;

        [DefaultValue(0), Category("Appearance")]
        public float MinValue { get; set; } = 0;

        [DefaultValue(260), Category("Appearance")]
        public float MaxValue { get; set; } = 260;

        [DefaultValue(20), Category("Appearance")]
        public float SeperationStepValue { get; set; } = 20;

        [DefaultValue(90), Category("Appearance")]
        public float DialOffsetAngle { get; set; } = 90;

        [DefaultValue(20), Category("Appearance")]
        public float DialLength { get; set; } = 20;

        [DefaultValue(40), Category("Appearance")]
        public float UnitTextOffset { get; set; } = 40;

        [DefaultValue(0), Category("Appearance")]
        public float Value 
        { 
            get 
            { 
                return _value; 
            }

            set
            {
                _value = value;
                Invalidate();
            }
        }

        [DefaultValue(30), Category("Appearance")]
        public float ValueHandStart { get; set; } = 30;

        [DefaultValue(140), Category("Appearance")]
        public float ValueHandEnd { get; set; } = 140;
    }
}
