using System;
using System.Drawing;

namespace WinFormsCarTools
{
    public struct PolarCoordinate
    {
        private float _xLength;
        private float _yLength;
        private float _angle;
        private PointF _offset;

        public PolarCoordinate(PointF Offset, float Length, float Angle) : this()
        {
            _xLength = Length;
            _yLength = Length;
            _angle = Angle;
            _offset = Offset;
            Recalculate();
        }

        public PolarCoordinate(PointF offset, float xLength, float yLength, float angle) : this()
        {
            _xLength = xLength;
            _yLength = yLength;
            _angle = angle;
            _offset = offset;
            Recalculate();
        }

        public PointF Cartesian { get; private set; }

        public float Length_X
        {
            get => _xLength;
            set
            {
                _xLength = value;
                Recalculate();
            }
        }

        public float Length_Y
        {
            get => _yLength;
            set
            {
                _yLength = value;
                Recalculate();
            }
        }

        public float Angle
        {
            get => _angle;
            set
            {
                _angle = value;
                Recalculate();
            }
        }

        public PointF Offset
        {
            get => _offset;
            set
            {
                _offset = value;
                Recalculate();
            }
        }

        internal float OriginalAngle { get; }

        private void Recalculate()
        {
            var x = Convert.ToSingle(Offset.X + Math.Cos(Angle * Math.PI / 180) * Length_X);
            var y = Convert.ToSingle(Offset.Y + Math.Sin(Angle * Math.PI / 180) * Length_Y);
            Cartesian = new PointF(x, y);
        }
    }
}
