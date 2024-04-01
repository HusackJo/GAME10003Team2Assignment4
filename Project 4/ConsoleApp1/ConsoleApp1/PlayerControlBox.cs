using Raylib_cs;
using System.Numerics;

namespace ConsoleApp1
{
    /* Class for the "hitboxes" or what players are gonna use to tap the hit tiles. the arrow shaped boxes that show up in DDR.
     * Update() is gonna play every frame. Draws the boxes and does a HitCheck()
     * Hitcheck() takes a tile as an argument, and is gonna be used to run functions for scoring points and playing sound
     */
    internal class PlayerControlBox
    {
        //Variables Baby!! 
        Vector2 position;
        Vector2 size;
        int positionTracker;
        public PlayerControlBox(int boxPlacement)
        {
            //give those variables some values!
            switch (boxPlacement)
            {
                case 0:
                    position = new Vector2(100, 780);
                    positionTracker = 0;
                    break;
                case 1:
                    position = new Vector2(260, 780);
                    positionTracker = 1;
                    break;
                case 2:
                    position = new Vector2(420, 780);
                    positionTracker = 2;
                    break;
                case 3:
                    position = new Vector2(580, 780);
                    positionTracker = 3;
                    break;
            }
            size = new Vector2(120, 120);
        }
        public void HitCheck(HitTile hitTile)
        {
            if (hitTile.GetPosY() >= 780 && hitTile.GetPosY() <= 820)
            {
                hitTile.Despawn();
                //they hit! maybe they get a point and increase their combo! who knows.
            }
            else
            {
                //they miss! maybe they drop their combo here, or lose a life. whatever yall feel like putting in.
            }
        }
        public void Update(HitTile hitTile)
        {
            //switchboard to only check for the correct key on each box
            switch (positionTracker)
            {
                case 0:
                    if (Raylib.IsKeyPressed(KeyboardKey.Left) && positionTracker == hitTile.GetTileID())
                    {
                        HitCheck(hitTile);
                    }
                    break;
                case 1:
                    if (Raylib.IsKeyPressed(KeyboardKey.Up) && positionTracker == hitTile.GetTileID())
                    {
                        HitCheck(hitTile);
                    }
                    break;
                case 2:
                    if (Raylib.IsKeyPressed(KeyboardKey.Down) && positionTracker == hitTile.GetTileID())
                    {
                        HitCheck(hitTile);
                    }
                    break;
                case 3:
                    if (Raylib.IsKeyPressed(KeyboardKey.Right) && positionTracker == hitTile.GetTileID())
                    {
                        HitCheck(hitTile);
                    }
                    break;
            }
            

            //im not gonna make another draw function this will work cause its just the one box lol
            Raylib.DrawRectangleLines(int.Parse(position.X.ToString()), int.Parse(position.Y.ToString()), int.Parse(size.X.ToString()), int.Parse(size.Y.ToString()), Color.SkyBlue);
        }

    }
}
