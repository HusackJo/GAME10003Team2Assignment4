namespace ConsoleApp1
{
    using Raylib_cs;
    using System;

    internal class Program
    {
        // define some variables
        // variables for the window
        static string title = "Rhythm Tiles";
        public static int windowWidth = 800;
        public static int windowHeight = 600;
        static void Main(string[] args)
        {
            //make a window!
            Raylib.InitWindow(windowWidth, windowHeight, title);
            Raylib.SetTargetFPS(60);

            Setup();
            //while the window's open, we run update every frame
            while (!Raylib.WindowShouldClose())
            {
                Update();
            }
            Raylib.CloseWindow();
            
        }
        static void Setup()
        {
             /*
             *4X player control boxes, WASD/ UpDownLeftRight
             * Tiles spawn[randomly ?] you'll need at least 4 objects
             */
        }
        static void Update()
        {
            //creating a canvas and doing black background 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);
            /*
             * player hits WASD (collision for box W or A or S, ect)
             *  {
             *      player gets a point?
             *      sound plays
             *  }
             *  move boxes
             *  timer increases?  
             */

            //this one stays on the bottom
            Raylib.EndDrawing();
        }
    }
}
