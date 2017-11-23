using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishChild : LiveInAqua
    {
        public FishChild(int x, int y, Graphics g)
        {
            creator = new FishChildCreator();
            creator.Create(g, x, y);
            X = x;
            Y = y;
            this.g = g;
        }


        public override void Move()
        {
            if (X < 1450)
                X += 20;
            else
            {
                if (X > 80)
                    X -= 20;
            }
            if (Y < 580)
                Y += 10;
            else
            {
                if (Y > 40)
                    Y -= 10;
            }
        }
    }
}
