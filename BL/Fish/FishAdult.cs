using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishAdult : LiveInAqua
    {

        public FishAdult(Graphics g, int x, int y)
        {
            creator = new FishAdultCreator();
            creator.Create(g, x, y);
            X = x - 75;
            Y = y - 47;
            Width = 150;
            Height = 95;
            this.g = g;
            TrgX = rnd.Next(80, 1450);
            TrgY = rnd.Next(40, 580);
            lifeRec = new Rectangle(x, y + 100, Width, 10);
        }

        public override void Move()
        {

            int dx = TrgX - x;
            int dy = TrgY - y;
            int stepX = 10;
            int stepY = 5;

            if (Math.Abs(dx) > 3)
            {
                if (dx < 0)              // рыбка правее точки
                    x -= stepX;
                else
                {
                    x += stepX;
                    turn = true;
                }
            }

            if (Math.Abs(dy) > 1)
            {
                if (dy < 0)                // рыбка ниже точки
                    y -= stepY;
                else
                    y += stepY;
            }
            lifeRec.X = X;
            lifeRec.Y = Y + 100;
        }
    }
}
