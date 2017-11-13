using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class ListOfAquaPeople : LiveInAqua
    {
        public List<LiveInAqua> residents;
        Drawing draw = new Drawing();
        Bitmap bmp;

        public ListOfAquaPeople()
        {
            residents = new List<LiveInAqua>();
        }

        public void Add(LiveInAqua p)
        {
            residents.Add(p);
        }

        public override void Move()
        {
            if (residents.Count != 0)
            {
                for (int i = 0; i < residents.Count; i++)
                {
                    residents.ElementAt<LiveInAqua>(i).Move();
                }
                bmp = draw.DrawMove(residents);
            }  
            else 
                bmp = new Bitmap(Image.FromFile("background.png"));
        }
        public Bitmap BM()
        {
            return bmp;
        }
    }
}
