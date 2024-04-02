namespace ConsoleApp1
{
    using Raylib_cs;
    using System;
    using System.Security.Cryptography;

    internal class Program
    {   
        // variables for the window
        static string title = "Rhythm Tiles";
        public static int windowWidth = 800;
        public static int windowHeight = 1000;

        public static HitTile[] hitTiles;
        public static PlayerControlBox[] controlBoxes;
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
            // adding a comment
            //setup for our 4 HitTile and PlayerControlBox objects. 0=Left 1=Up 2=Down 3=Right (DDR notation)
            /*
            hitTiles = new HitTile[4];
            for (int i = 0; i < hitTiles.Length; i++)
            {
                hitTiles[i] = new HitTile(i);
            }
            controlBoxes = new PlayerControlBox[4];
            for (int i = 0; i < controlBoxes.Length; i++)
            {
                controlBoxes[i] = new PlayerControlBox(i);
            }
            */
        }
        static void Update()
        {
            //creating a canvas and doing black background 
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            /*
            foreach (HitTile hitTile in hitTiles)
            {
                hitTile.Update();
            }
            for (int i = 0; i < controlBoxes.Length; i++)
            {
                controlBoxes[i].Update(hitTiles[i]);
            }
            */
            

            //this one stays on the bottom
            Raylib.EndDrawing();
        }


        public enum Direction
        {
            Left,
            Up,
            Down,
            Right
        }
    }
}
