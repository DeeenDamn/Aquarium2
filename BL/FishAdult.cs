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
        private int x;
        private int y;
        Graphics g;

        public FishAdult(int x, int y, Graphics g)
        {
            this.x = x;
            this.y = y;
            this.g = g;
        }
    }
}
