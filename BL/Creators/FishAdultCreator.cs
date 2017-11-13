using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FishAdultCreator : ICreator
    {
        public void Create(Graphics g, int x, int y)
        {
            g.DrawImage(Image.FromFile("fish.png"), x - 75, y - 47, 150, 95);
        }
    }
}
