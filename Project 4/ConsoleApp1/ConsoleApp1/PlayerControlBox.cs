using Raylib_cs;
using System.Numerics;

namespace ConsoleApp1
{
    /* Class for the "hitboxes" or what players are gonna use to tap the hit tiles. the arrow shaped boxes that show up in DDR.
     * Update() is gonna play every frame. Draws the boxes and does a HitCheck[er]
     * 
     */
    internal class PlayerControlBox
    {
        //Variables Baby!! 
        Vector2 position;
        Vector2 size;
        PlayerControlBox()
        {
            //give those variables some values!
        }
        public void HitCheck(HitTile hitTile)
        {
            if (/*they line up*/true)
            {
                hitTile.Despawn();
            }
            else
            {
                //they miss! run a public function in the point tracker here?
            }
        }
        public void Update()
        {
            //
            // if (keydown)
            //HitChecker(corresponding hittile);
            //draw
            Raylib.DrawRectangleLines(int.Parse(position.X.ToString()), int.Parse(position.Y.ToString()), int.Parse(size.X.ToString()), int.Parse(size.Y.ToString()), Color.SkyBlue);
        }

    }
}
