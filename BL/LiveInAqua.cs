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
        protected int width;
        protected int height;
        public bool Death { get; protected set; } = false;

        public int TrgX { get; protected set; }
        public int TrgY { get; protected set; }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int health = 100;
        public Rectangle lifeRec;
        public bool turn = false;
        protected Graphics g;
        protected Random rnd = new Random();
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

        public virtual void Die()
        {
            if (Y > 25)
                Y -= 7;
            else
                Death = true;
        }
        

    }
}
