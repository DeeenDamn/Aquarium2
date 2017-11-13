using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishAdult : LiveInAqua //Fish
    {
        int rightcount = 0;
        int leftcount = 0;
        int upcount = 0;
        int downcount = 0;
        Random rnd = new Random();
        public FishAdult(Graphics g, int x, int y)
        {
            creator = new FishAdultCreator();
            creator.Create(g, x, y);
            X = x;
            Y = y;
            this.g = g;
            
        }

        public override void Move()
        {
            int a = rnd.Next(0, 2);
            if (X < 1450 && X > 80)
            {
                if (a == 0)
                {
                    turn = true;
                    X += 25;
                }
                else
                    X -= 25;
            }
            else
            {
                if (X < 1450)
                {
                    turn = true;
                    X += 30;
                }
                else
                    X -= 30;
            }
            a = rnd.Next(0, 2);
            if (Y < 580 && Y > 40)
            {
                if (a == 0 )
                {
                    Y += 20;
                }
               else
                {
                    Y -= 20;
                }
            }
            else
            {
                if (Y < 580)
                    Y += 25;
                else
                    Y -= 25;
            }
        }       
    }
}
