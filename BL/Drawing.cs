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
        Bitmap bmp = new Bitmap(Image.FromFile("background.png"));
        Graphics g;
        Image leftfish = Image.FromFile("fish.png");
        Image rightfish = Image.FromFile("fish.png");
        Image back = Image.FromFile("background.png");

        public Drawing()
        {
            rightfish.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        public Bitmap DrawMove(List<LiveInAqua> residents)
        {
            bmp.Dispose();
            bmp = new Bitmap(back);
            g = Graphics.FromImage(bmp);
            for (int i = 0; i < residents.Count; i++)
            {
                if (residents.ElementAt(i) is FishAdult)
                {
                    if (residents.ElementAt(i).turn)
                    {
                        g.DrawImage(rightfish, residents.ElementAt(i).X - 75, residents.ElementAt(i).Y - 47, 150, 95);
                        residents.ElementAt(i).turn = false;
                    }
                    else
                        g.DrawImage(leftfish, residents.ElementAt(i).X - 75, residents.ElementAt(i).Y - 47, 150, 95);
                }
                if (residents.ElementAt(i) is FishChild)
                {
                    if (residents.ElementAt(i).turn)
                    {
                        g.DrawImage(rightfish, residents.ElementAt(i).X - 25, residents.ElementAt(i).Y - 30, 50, 32);
                        residents.ElementAt(i).turn = false;
                    }
                    else
                        g.DrawImage(leftfish, residents.ElementAt(i).X - 25, residents.ElementAt(i).Y - 30, 50, 32);
                }
                DrawHealth(residents.ElementAt(i).lifeRec, residents.ElementAt(i).health);
            }
            return bmp;
        }

        private void DrawHealth(Rectangle rec, int health)
        {
            Font myFont = new Font("Times New Roman", 13, FontStyle.Bold);
            if (health >= 0)
            {
                g.FillRectangle(Brushes.Red, rec);
                if (health >= 5)
                {
                    g.FillRectangle(Brushes.Tomato, rec);
                    if (health >= 30)
                    {
                        g.FillRectangle(Brushes.Yellow, rec);
                        if (health >= 70)
                        {
                            g.FillRectangle(Brushes.LawnGreen, rec);
                        }
                    }
                }
                g.DrawRectangle(Pens.Black, rec);
                g.DrawString(health.ToString(), myFont, Brushes.Black, rec.Location.X + rec.Size.Width / 2 - 10, rec.Location.Y - rec.Size.Height / 2);
            }

        }
    }
}
