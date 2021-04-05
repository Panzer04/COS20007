using System;
using SplashKitSDK;


namespace ShapeDrawer
{

    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle
        }
        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;

            new Window("Shape Drawer", 800, 600);
            Drawing drawObject = new Drawing();
            do
            {
                SplashKit.ProcessEvents(); //Check user inputs - should only call once
                SplashKit.ClearScreen(); //Clear screen to white                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;

                    if (SplashKit.KeyTyped(KeyCode.RKey))
                    {
                        kindToAdd = ShapeKind.Rectangle;
                    }
                    else if (SplashKit.KeyTyped(KeyCode.CKey))
                    {
                        kindToAdd = ShapeKind.Circle;
                    }

                    if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();
                        newCircle.X = SplashKit.MouseX();
                        newCircle.Y = SplashKit.MouseY();
                        newShape = newCircle;
                    }
                    else
                    {
                        MyRectangle newRectangle = new MyRectangle();
                        newRectangle.X = SplashKit.MouseX();
                        newRectangle.Y = SplashKit.MouseY();
                        newShape = newRectangle;
                    }

                    //No good way to instantiate a shape with different params directly in method?
                    //Shape constructor needs ability to accept X/Y paramters, I guess?
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
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
                drawObject.Draw();
                SplashKit.RefreshScreen(); //Target FPS? Should have an uint argument?
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}