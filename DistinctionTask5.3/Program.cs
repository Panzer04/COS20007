using System;
using SplashKitSDK;


namespace ShapeDrawer
{

    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }
        public static void Main()
        {
            //Add the Type MyRectangle to the register
            Shape.RegisterShape("Rectangle", typeof(MyRectangle));
            Shape.RegisterShape("Circle", typeof(MyCircle));
            Shape.RegisterShape("Line", typeof(MyLine));

            ShapeKind kindToAdd = ShapeKind.Rectangle;
            Point2D lineStart = new Point2D(){X = 0, Y = 0 };
            Point2D lineEnd;
            new Window("Shape Drawer", 800, 600);
            Drawing drawObject = new Drawing();
            do
            {
                SplashKit.ProcessEvents(); //Check user inputs - should only call once
                SplashKit.ClearScreen(); //Clear screen to white

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                else if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }else if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                    lineStart.X = SplashKit.MouseX();
                    lineStart.Y = SplashKit.MouseY();
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;


                    if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                    }
                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle();
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                    }
                    else
                    {
                        lineEnd.X = SplashKit.MouseX();
                        lineEnd.Y = SplashKit.MouseY();
                        Line tempLine;
                        tempLine.StartPoint = lineStart;
                        tempLine.EndPoint = lineEnd;
                        newShape = new MyLine(tempLine);
                    }

                    //No good way to instantiate a shape with different params directly in method?
                    //Shape constructor needs ability to accept X/Y paramters, I guess?
                    //newShape.X = SplashKit.MouseX();
                    //newShape.Y = SplashKit.MouseY();
                    drawObject.AddShape(newShape);

                }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    drawObject.Background = SplashKit.RandomRGBColor(255); //Alpha set to 255
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawObject.SelectSchapesAt(SplashKit.MousePosition());
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in drawObject.SelectedShapes)
                        drawObject.RemoveShape(s);
                }
                if (SplashKit.KeyTyped(KeyCode.SKey))
                {
                    drawObject.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TestDrawing.txt");
                }
                if (SplashKit.KeyTyped(KeyCode.OKey))
                {
                    try
                    {
                        drawObject.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TestDrawing.txt");
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine("Error loading file: {0}", e.Message);
                    }
                    
                }
                drawObject.Draw();
                SplashKit.RefreshScreen(); //Target FPS? Should have an uint argument?
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}