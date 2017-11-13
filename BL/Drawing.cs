using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BL
{
    public class Drawing
    {
        private Bitmap bmp = new Bitmap(Image.FromFile("background.png"));
        Graphics g;
        Image leftfish = Image.FromFile("fish.png");
        Image rightfish = Image.FromFile("fish.png");


        public Drawing()
        {
            rightfish.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        public Bitmap DrawMove(List<LiveInAqua> residents)
        {
            bmp = new Bitmap(Image.FromFile("background.png"));
            g = Graphics.FromImage(bmp);
            for (int i=0; i<residents.Count; i++)
            {
                if (residents.ElementAt<LiveInAqua>(i) is FishAdult)
                {
                    if (residents.ElementAt<LiveInAqua>(i).turn)
                    {
                        g.DrawImage(rightfish, residents.ElementAt<LiveInAqua>(i).X - 75, residents.ElementAt<LiveInAqua>(i).Y - 47, 150, 95);
                        residents.ElementAt<LiveInAqua>(i).turn = false;
                    }
                    else
                        g.DrawImage(leftfish, residents.ElementAt<LiveInAqua>(i).X - 75, residents.ElementAt<LiveInAqua>(i).Y - 47, 150, 95);
                }
                if (residents.ElementAt<LiveInAqua>(i) is FishChild)
                {
                    if (residents.ElementAt<LiveInAqua>(i).turn)
                    {
                        g.DrawImage(rightfish, residents.ElementAt<LiveInAqua>(i).X - 25, residents.ElementAt<LiveInAqua>(i).Y - 30, 50, 32);
                        residents.ElementAt<LiveInAqua>(i).turn = false;
                    }
                    else
                        g.DrawImage(leftfish, residents.ElementAt<LiveInAqua>(i).X - 25, residents.ElementAt<LiveInAqua>(i).Y - 30, 50, 32);
                }
            }
            return bmp;
        }

    }
}
