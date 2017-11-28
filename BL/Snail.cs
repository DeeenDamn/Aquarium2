using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class Snail : LiveInAqua
    {
        public Snail(Graphics g, int x, int y)
        {
            creator = new SnailCreator();
            creator.Create(g, x, y);
            X = x - 75;
            Y = y - 47;
            Width = 150;
            Height = 95;
            this.g = g;
            TrgX = rnd.Next(80, 1400);
            lifeRec = new Rectangle(x, y + 50, Width, 5);
            
        }

        public override void Move()
        {
            int dx = TrgX - x;
            int stepX = 2;
            if (Math.Abs(dx) > 3)
            {
                if (dx < 0)              // улитка правее точки
                    x -= stepX;
                else
                {
                    x += stepX;
                    turn = true;
                }
            }
            lifeRec.X = X;

        }

    }
}
