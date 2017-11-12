using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FishChildCreator : ICreator
    {
        public void Create(Graphics g, int x, int y)
        {
            g.DrawImage(Image.FromFile("fish.png"), x - 25, y - 30, 50, 32);
        }
    }
}
