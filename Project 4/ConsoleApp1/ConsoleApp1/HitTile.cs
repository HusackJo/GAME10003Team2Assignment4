using Raylib_cs;
using System.Numerics;

namespace ConsoleApp1
{
    /* This is the class for the tiles that will be falling!
       Update() should play every frame: moves, Do[es]FloorCollision(), draws
       DoFloorCollision() checks if the tile has touched the bottom of the window (Despawn() when true)
       Repawn() will move the tile to it's assigned spawn position (the top of the screen) for it to fall into place 
       Despawn() moves the tile to outside the bounds of the window so we don't need to worry about it there.
    */
    internal class HitTile
    {
        //define variables
        Vector2 position;
        Vector2 size;
        Vector2 velocity;
        Vector2 spawnPos;
        int floorHeight = Program.windowHeight;

        HitTile()
        {
            //give variables values
        }
        public void Update()
        {
            //move
            position += velocity;
            //
            DoFloorCollision();
            //draw
            Raylib.DrawRectangleV(position, size, Color.SkyBlue);
        }
        public void DoFloorCollision()
        {
            if (position.Y >= floorHeight - size.Y && velocity.Y >= 0)
            {
                Despawn();
            }
        }
        public void Respawn()
        {
            position = spawnPos;
        }
        public void Despawn()
        {
            position.X += 2000000;
        }
    }
}
