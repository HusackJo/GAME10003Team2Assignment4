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
        PlayerControlBox(int boxPlacement)
        {
            //give those variables some values!
            switch (boxPlacement)
            {
                case 0:
                    position = new Vector2(100, 780);
                    break;
                case 1:
                    position = new Vector2(260, 780);
                    break;
                case 2:
                    position = new Vector2(420, 780);
                    break;
                case 3:
                    position = new Vector2(580, 780);
                    break;
            }
            size = new Vector2(120, 120);
        }
        public void HitCheck(HitTile hitTile)
        {
            if (/*they hit!*/true)
            {
                hitTile.Despawn();
                //they hit! maybe they get a point and increase their combo! who knows.
            }
            else
            {
                //they miss! maybe they drop their combo here, or lose a life. whatever yall feel like putting in.
            }
        }
        public void Update()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Up))
            {

            }

            //im not gonna make another draw function this will work cause its just the one box lol
            Raylib.DrawRectangleLines(int.Parse(position.X.ToString()), int.Parse(position.Y.ToString()), int.Parse(size.X.ToString()), int.Parse(size.Y.ToString()), Color.SkyBlue);
        }

    }
}
