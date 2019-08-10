using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsCarTools
{
    public class GForceVisualizerControl : Control
    {
        public event EventHandler XGForceChanged;
        public event EventHandler YGForceChanged;

        private readonly Timer animationTimer;

        private float _xGforce;
        private float _yGforce;
        private int _maxGUnits = 2;
        private float _gUnitPartitioning = 0.5F;
        private float _previousXGforce;
        private float _previousYGforce;

        private Pen _forecolorPen;
        private Brush _forecolorBrush;
        private float _forecolorPenWidth = 2;

        public GForceVisualizerControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        public float XGforce
        {
            get => _xGforce;

            set
            {
                if (!object.Equals(_xGforce,value))
                {
                    _previousXGforce = _xGforce;
                    _xGforce = value;
                    OnXGForceChanged(EventArgs.Empty);
                }
            }
        }

        public float YGforce
        {
            get => _yGforce;

            set
            {
                if (!object.Equals(_yGforce, value))
                {
                    _previousYGforce = _yGforce;
                    _yGforce = value;
                    OnYGForceChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnXGForceChanged(EventArgs e)
        {
            Invalidate();
            var xForceChangedEvent = XGForceChanged;
            if (!(xForceChangedEvent is null))
            {
                xForceChangedEvent(this, e);
            }
        }

        protected virtual void OnYGForceChanged(EventArgs e)
        {
            Invalidate();
            var yForceChangedEvent = YGForceChanged;
            if (!(yForceChangedEvent is null))
            {
                yForceChangedEvent(this, e);
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if (_forecolorPen is null)
            {
                return;
            }

            _forecolorBrush = new SolidBrush(ForeColor);
            _forecolorPen = new Pen(_forecolorBrush, _forecolorPenWidth);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(BackColor);
            if (_forecolorPen is null)
            {
                _forecolorBrush = new SolidBrush(ForeColor);
                _forecolorPen = new Pen(_forecolorBrush, _forecolorPenWidth);
            }

            // Draw Scaling Circles
            var unitWidth = ClientRectangle.Width / (_maxGUnits / _gUnitPartitioning) / 2;
            var unitHeight = ClientRectangle.Height / (_maxGUnits / _gUnitPartitioning) / 2; 
            var ellipseRectangle = new RectangleF(ClientRectangle.Width / 2 - unitWidth,
                                                  ClientRectangle.Height / 2 - unitHeight, 
                                                  unitWidth * 2,
                                                  unitHeight * 2);

            for (float gUnits = 0; gUnits< _maxGUnits; gUnits += _gUnitPartitioning)
            {
                g.DrawEllipse(_forecolorPen, ellipseRectangle);
                ellipseRectangle.Inflate(unitWidth, unitHeight);
            }

            // Draw indicator.
            var indicatorWidth = ClientRectangle.Width / 40;
            var indicatorHeight = ClientRectangle.Height / 40;

            g.FillEllipse(_forecolorBrush,
                new RectangleF(ClientRectangle.Width / 2 + XGforce * (ClientRectangle.Width / (_maxGUnits * 2)) - indicatorWidth,
                               ClientRectangle.Height / 2 + YGforce * (ClientRectangle.Height / (_maxGUnits * 2)) - indicatorHeight,
                                indicatorWidth * 2,
                                indicatorHeight * 2));
        }
    }
}
