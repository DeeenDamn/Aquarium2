using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishAdult : Fish
    {
        public FishAdult(Graphics g, int x, int y)
        {
            creator = new FishAdultCreator();
            creator.Create(g, x, y);
            this.x = x;
            this.y = y;
            this.g = g;
            
        }

    }
}
