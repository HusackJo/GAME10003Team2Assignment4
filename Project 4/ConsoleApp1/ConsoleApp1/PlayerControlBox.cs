using Raylib_cs;
using System.Numerics;

namespace ConsoleApp1
{
    internal class PlayerControlBox
    {
        //Variables Baby!! 
        Vector2 position;
        Vector2 size;
        PlayerControlBox()
        {
            //give those variables some values!
        }
        public void HitChecker(HitTile hitTile)
        {
            if (/*they line up*/true)
            {
                hitTile.Despawn();
            }
            else
            {
                //they miss! point tracker runs a function here?
            }
        }
    }
}
