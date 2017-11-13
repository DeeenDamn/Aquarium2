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


        public FishChild(int x, int y, Graphics g)
        {
            creator = new FishChildCreator();
            this.x = x;
            this.y = y;
            this.g = g;
        }
    }
}
