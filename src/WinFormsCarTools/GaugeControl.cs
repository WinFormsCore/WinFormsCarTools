using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsCarTools
{
    class GaugeControl : Control
    {
        private int _gaugeStartAngle = 40;
        private int _gaugeEndAngle = 320;
        private float _minValue = 0;
        private float _maxValue = 260;
        private float _seperationStepValue = 20;
        private float _dialOffsetAngle = 90;
        private float _dialLength = 20;

        public GaugeControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
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

            //Outer Clock circle
            g.DrawEllipse(foreColorPen, closeSize);

            //Draw the dial.

            float dialSteps = (_maxValue - _minValue) / _seperationStepValue;
            float angleStep = (_gaugeEndAngle - _gaugeStartAngle) / dialSteps;

            for (float angle = _gaugeStartAngle; angle <= _gaugeEndAngle; angle += angleStep)
            {
                PolarCoordinate pcStart = new PolarCoordinate(center, size.Width, size.Height, angle + _dialOffsetAngle);
                PolarCoordinate pcEnd = new PolarCoordinate(center, size.Width - _dialLength, size.Height - _dialLength, angle + _dialOffsetAngle);
                g.DrawLine(Pens.Black, pcStart.Cartesian.X, pcStart.Cartesian.Y, pcEnd.Cartesian.X, pcEnd.Cartesian.Y);

                // Draw caption.
                g.DrawString("200", Font, foreColorBrush, pcEnd.Cartesian);
            }
        }
    }
}
