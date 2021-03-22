using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    class Drawing
    {
        
        private Color _background;
        private readonly List<Shape> _shapes;
        public Drawing(Color background) //Constructor
        {
            _background = background;
            _shapes = new List<Shape>();
        }
        public Drawing() : this(Color.White)
        {

        }


        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach(Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach(Shape s in _shapes)
            {
                s.Draw();
            }
        }

        public void SelectSchapesAt(Point2D pt)
        {
            foreach(Shape s in _shapes)
            {
                if (!s.Selected) //Don't "unselect" shapes - Depends on exact desired behaviour, though
                {
                    s.Selected = s.IsAt(pt);
                }
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }
        
    }
}
