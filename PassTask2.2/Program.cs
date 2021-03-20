using System;
using SplashKitSDK;


namespace ShapeDrawer
{

    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Shape myShape = new Shape();
            do
            {
                SplashKit.ProcessEvents(); //Check user inputs - should only call once
                SplashKit.ClearScreen(); //Clear screen to white                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                }
                if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Color = SplashKit.RandomRGBColor(255);
                }
                myShape.Draw();
                SplashKit.RefreshScreen(); //Target FPS? Should have an uint argument?
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}