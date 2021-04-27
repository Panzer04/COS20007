using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        //Match string to type (eg. "Rectangle" -> MyRectangle)
        private static Dictionary<string, Type> _ShapeCLassRegistry = new Dictionary<string, Type>();

        public static void RegisterShape(string name, Type t)
        {
            _ShapeCLassRegistry[name] = t;
        }

        //Use a string identifier to specify a type to retrieve from the dictionary, then
        //create an instance of the specified type from registry, and cast it to shape
        public static Shape CreateShape(string name)
        {
            return (Shape)Activator.CreateInstance(_ShapeCLassRegistry[name]);
        }

        protected Color _color;
        private float _x, _y;

        private bool _selected;



        public Shape(): this(Color.Green) //Class constructor
        {
            _x = 0;
            _y = 0;
        }

        public Shape(Color clr)
        {
            _color = clr;
        }



        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }


        public bool Selected
        {
            get
            {
                return _selected;
            }

            set
            {
                _selected = value;
            }
        }
        public abstract void Draw();

        public abstract bool IsAt(Point2D pt);

        public abstract void DrawOutline();

        public virtual void SaveTo(StreamWriter writer)
        {
            writer.WriteLine(Shape.GetKey(this.GetType()));
            writer.WriteColor(Color);
            writer.WriteLine(X);
            writer.WriteLine(Y);
        }

        public virtual void LoadFrom(StreamReader reader)
        {
            Color = reader.ReadColor();
            X = reader.ReadInteger();
            Y = reader.ReadInteger();
        }

        static string GetKey(Type t)
        {
            foreach(string key in _ShapeCLassRegistry.Keys)
            {
                if(_ShapeCLassRegistry[key] == t)
                {
                    return key;
                }
            }
            throw new KeyNotFoundException();
        }

    }
}
