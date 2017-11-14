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

        public int TrgX { get; protected set; }
        public int TrgY { get; protected set; }

        public int health = 100;
        public Rectangle lifeRec;
        public bool turn = false;
        protected Graphics g;
        protected Random rnd = new Random();

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

        public virtual void SetPoint()
        {
            
            TrgX = rnd.Next(80, 1450);
            TrgY = rnd.Next(40, 580);
        }
    }
}
