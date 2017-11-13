using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public abstract class LiveInAqua
    {
        protected int x;
        protected int y;
        public bool turn = false;
        protected Graphics g;
        //protected Bitmap bmp;

        public ICreator creator;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }         

        public void Create()
        {
            creator.Create(g, x, y);
        }

        public abstract void Move();        
    }
}
