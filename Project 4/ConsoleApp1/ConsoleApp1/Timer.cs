using System;
using System.Xml;
using Raylib_cs;

class Program
{
    static void Timer(string[] args)
    {
        const int screenWidth = 800;
        const int screenHeight = 450;

        Raylib.InitWindow(screenWidth, screenHeight, "Automatic Timer");

        int seconds = 0;
        DateTime startT = DateTime.Now;

        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            TimeSpan elapsedTime = DateTime.Now - startT;
            seconds = (int)elapsedTime.TotalSeconds;

            Raylib.DrawText($"Time elapsed: {seconds} seconds", 10, 10, 20, Color.Black);

            Raylib.EndDrawing();

        }

        Raylib.CloseWindow();
    }
}