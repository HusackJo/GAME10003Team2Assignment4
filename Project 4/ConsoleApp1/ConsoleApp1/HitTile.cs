using Raylib_cs;
using System.Numerics;

namespace ConsoleApp1
{
    /* This is the class for the tiles that will be falling!
       Update() should play every frame: moves, Do[es]FloorCollision(), draws, and checks Respawn()
       DoFloorCollision() checks if the tile has touched the bottom of the window (Despawn() when true)
       Repawn() will move the tile to it's assigned spawn position (the top of the screen) if its despawned and the rng works out 
       Despawn() moves the tile to outside the bounds of the window so we don't need to worry about it there.
    */
    internal class HitTile
    {
        //define variables
        public static Vector2 position;
        Vector2 size;
        Vector2 velocity;
        Vector2 spawnPos;
        int spawnTimer;
        int floorHeight = Program.windowHeight;
        int tileID;
        Random rng = new Random();

        public HitTile(int tilePlacement)
        {
            //variables get values
            position = new Vector2(-80, -80);
            size = new Vector2(80, 80);
            velocity = new Vector2(0, 2);
            switch (tilePlacement)
            {
                case 0:
                    spawnPos = new Vector2(120, -80);
                    tileID = 0;
                    break;
                case 1:
                    spawnPos = new Vector2(280, -80);
                    tileID = 1;
                    break;
                case 2:
                    spawnPos = new Vector2(440, -80);
                    tileID = 2;
                    break;
                case 3:
                    spawnPos = new Vector2(600, -80);
                    tileID = 3;
                    break;
            }
            spawnTimer = 10000;
        }
        public void Update()
        {
            //respawn?
            Respawn();
            //move
            position += velocity;
            //
            DoFloorCollision();
            //draw
            Raylib.DrawRectangleV(position, size, Color.White);
        }
        public void DoFloorCollision()
        {
            if (position.Y >= floorHeight - size.Y)
            {
                Despawn();
            }
        }
        public void Respawn()
        {
            spawnTimer++;
            if (spawnTimer > 0 && position.X < 0)
            {
                if (rng.Next(1, 200) <= 3)//a 1.5% chance called 60 times a second
                {
                    position = spawnPos;
                    spawnTimer = 0;
                }
            }
        }
        public void Despawn()
        {
            //i hope someone sees this comedically high number send me a message if u do lol
            position.X -= 2000000;
        }
        public int GetPosY()
        {
            return (int.Parse(position.Y.ToString()));
        }
        public int GetTileID()
        {
            return tileID;
        }
    }
}

