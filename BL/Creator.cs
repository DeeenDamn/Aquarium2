using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public abstract class Creator
    {
        //public List<Creator> fishes = new List<Creator>();     ????

        public abstract void Create(Graphics g, int x, int y);
    }
}
