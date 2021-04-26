using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle() : this(Color.Blue, 50)
        {
        }

        public MyCircle(Color clr, int radius)
        {
            _radius = radius;
            _color = clr;
        }

        public override bool IsAt(Point2D pt)
        {
            //Find the difference between the point we clicked and the X/Y coords of the centre of the circle
            //If this distance is less than the radius of the circle, by pythagorus we know this is valid.
            double x2 = (pt.X - X) * (pt.X - X);
            double y2 = (pt.Y - Y) * (pt.Y - Y);
            if(Math.Sqrt(x2 + y2) < _radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 2);
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Circle");
            base.SaveTo(writer);
            writer.WriteLine(_radius);
        }
    }
}
