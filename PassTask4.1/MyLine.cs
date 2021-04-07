using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        Line _line;
        DrawingOptions DrawingOptions = new DrawingOptions() { LineWidth = 5 };
        public MyLine()
        {

        }

        public MyLine(Line line)
        {
            _line = line;
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(_color, _line);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, _line.EndPoint.X, _line.EndPoint.Y, 3);
            SplashKit.FillCircle(Color.Black, _line.StartPoint.X, _line.StartPoint.Y, 3);

        }

        /*
        Need to check if the selecting point is on the line (or close enough)
        "Close enough" in this case was chosen as 5 pixels.
        Calculated by normalising points relative to 0, rotating line onto x axis, rotating point by same amount,
        and checking that is within specified bounds. Rotation allows for us to easily check the proximity of pt
        */
        public override bool IsAt(Point2D pt)
        {
            double tolerance = 5;
            Point2D normalisedLine;
            Point2D normalisedPoint;
            Point2D rotatedNormalisedLine;
            Point2D rotatedNormalisedPoint;
            //Normalise points relative to origin (ie. vector from 0,0)
            normalisedLine.X = _line.EndPoint.X - _line.StartPoint.X;
            normalisedLine.Y = _line.EndPoint.Y - _line.StartPoint.Y;
            normalisedPoint.X = _line.EndPoint.X - pt.X;
            normalisedPoint.Y = _line.EndPoint.Y - pt.Y;
            //Rotate lines onto X axis
            double theta = Math.Atan2(normalisedLine.Y, normalisedLine.X);
            rotatedNormalisedLine.X = Math.Cos(theta) * normalisedLine.X + Math.Sin(theta) * normalisedLine.Y;
            rotatedNormalisedLine.Y = Math.Cos(theta) * normalisedLine.Y - Math.Sin(theta) * normalisedLine.X;
            rotatedNormalisedPoint.X = Math.Cos(theta) * normalisedPoint.X + Math.Sin(theta) * normalisedPoint.Y;
            rotatedNormalisedPoint.Y = Math.Cos(theta) * normalisedPoint.Y - Math.Sin(theta) * normalisedPoint.X;
            //Check distance of rotated pt from line
            if (Math.Abs(rotatedNormalisedPoint.Y - rotatedNormalisedLine.Y) < tolerance)
            {
                if (rotatedNormalisedPoint.X < rotatedNormalisedLine.X + tolerance && rotatedNormalisedPoint.X > -tolerance)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
