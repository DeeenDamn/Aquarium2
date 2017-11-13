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
        protected Graphics g;
        protected Bitmap bmp;

        public ICreator creator;

    }
}
