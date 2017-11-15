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
        Image leftdie = Image.FromFile("fish.png");
        Image rightdie = Image.FromFile("fish.png");

        public Drawing()
        {
            rightfish.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdie.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdie.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            leftdie.RotateFlip(RotateFlipType.RotateNoneFlipXY);
        }

        public Bitmap DrawMove(List<LiveInAqua> residents)
        {
            bmp.Dispose();
            bmp = new Bitmap(back);
            g = Graphics.FromImage(bmp);
            for (int i = 0; i < residents.Count; i++)
            {
                if (residents.ElementAt(i).Death)
                {
                    g.DrawImage(Image.FromFile("death.png"), residents.ElementAt(i).X, residents.ElementAt(i).Y, 150, 150);
                    residents.RemoveAt(i);
                    continue;                    
                }
                if (residents.ElementAt(i).turn)
                {
                    if (residents.ElementAt(i).health != 0)
                    {
                        g.DrawImage(rightfish, residents.ElementAt(i).X, residents.ElementAt(i).Y, residents.ElementAt(i).Width, residents.ElementAt(i).Height);
                        residents.ElementAt(i).turn = false;
                    }
                    else
                    {
                        g.DrawImage(rightdie, residents.ElementAt(i).X, residents.ElementAt(i).Y, residents.ElementAt(i).Width, residents.ElementAt(i).Height);
                    }

                }
                else
                {
                    if (residents.ElementAt(i).health != 0)
                    {
                        g.DrawImage(leftfish, residents.ElementAt(i).X, residents.ElementAt(i).Y, 150, 95);
                    }
                    else
                    {
                        g.DrawImage(leftdie, residents.ElementAt(i).X, residents.ElementAt(i).Y, residents.ElementAt(i).Width, residents.ElementAt(i).Height);
                    }
                }
                DrawHealth(residents.ElementAt(i).lifeRec, residents.ElementAt(i).health);
            }
            return bmp;
        }

        private void DrawHealth(Rectangle rec, int health)
        {
            if (health > 0)
            {
                Font myFont = new Font("Times New Roman", 13, FontStyle.Bold);
                int R = (int)(0 + 4.18 * (100 - health));
                int G = 209;
                if (R > 207)
                {
                    G = (int)(209 - 4.18 * (50 - health));
                    R = 209;
                }
                int B = 0;
                SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
                g.FillRectangle(brush, rec.X, rec.Y, rec.Width * health / 100, rec.Height);
                g.DrawRectangle(Pens.Black, rec);
                g.DrawString(health.ToString(), myFont, Brushes.Black, rec.Location.X + rec.Size.Width / 2 - 10, rec.Location.Y - rec.Size.Height / 2);
            }
        }
    }
}
