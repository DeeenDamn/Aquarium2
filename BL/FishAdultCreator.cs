using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FishAdultCreator : Creator
    {
        public override void Create(Graphics g, int x, int y)
        {
            g.DrawImage(Image.FromFile("fish.png"), x - 150, y - 95, 300, 191);
        }
    }
}
