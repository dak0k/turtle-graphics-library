using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleGraphics
{
    public class Turtle
    {
        private PictureBox _canvas;
        private Graphics _graphics;
        private PointF _position;
        private float _angle;

        public Turtle(PictureBox canvas)
        {
            _canvas = canvas;
            _graphics = _canvas.CreateGraphics();
            _position = new PointF(_canvas.Width / 2, _canvas.Height / 2);
            _angle = 0;
        }

        public void Forward(float distance)
        {
            PointF newPos = new PointF(_position.X + distance * (float)Math.Cos(_angle * Math.PI / 180),
                                       _position.Y - distance * (float)Math.Sin(_angle * Math.PI / 180));
            _graphics.DrawLine(Pens.Black, _position, newPos);
            _position = newPos;
        }

        public void TurnLeft(float angle)
        {
            _angle -= angle;
        }

        public void TurnRight(float angle)
        {
            _angle += angle;
        }

        public void PenUp()
        {
            _graphics = _canvas.CreateGraphics();
        }

        public void PenDown()
        {
            _graphics = Graphics.FromImage(_canvas.Image);
        }

        public void Clear()
        {
            _graphics.Clear(Color.White);
        }
    }
}
