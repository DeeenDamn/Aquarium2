using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishChild : Fish
    {
        private int x;
        private int y;
        Graphics g;

        public FishChild(int x, int y, Graphics g)
        {
            this.x = x;
            this.y = y;
            this.g = g;
        }
    }
}
