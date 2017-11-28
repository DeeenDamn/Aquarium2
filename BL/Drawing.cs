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
        Image leftdiefish = Image.FromFile("fish.png");
        Image rightdiefish = Image.FromFile("fish.png");
        Image leftdiesnail = Image.FromFile("snail.png");
        Image rightdiesnail = Image.FromFile("snail.png");
        Image leftsnail = Image.FromFile("snail.png"); //
        Image rightsnail = Image.FromFile("snail.png"); //


        public Drawing()
        {
            rightfish.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdiefish.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdiefish.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            leftdiefish.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            rightsnail.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdiesnail.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdiesnail.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            leftdiesnail.RotateFlip(RotateFlipType.RotateNoneFlipY);
        }

        public Bitmap DrawAll(Aquarium sea)
        {
            bmp.Dispose();
            bmp = new Bitmap(back);
            g = Graphics.FromImage(bmp);
            DrawMoveFish(sea.AllFish);
            DrawMoveSnail(sea.AllSnail); //////////
            if (sea.Ohapka.Count != 0)
                DrawFood(sea.Ohapka);
            return bmp;

        }

        private void DrawMoveFish(ListOfAquaPeople swimmers)
        {
            
            for (int i = 0; i < swimmers.residents.Count; i++)
            {
                if (swimmers.residents.ElementAt(i).Death)
                {
                    g.DrawImage(Image.FromFile("death.png"), swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, 150, 150);
                    swimmers.residents.RemoveAt(i);
                    continue;                    
                }
                if (swimmers.residents.ElementAt(i).turn)
                {
                    if (swimmers.residents.ElementAt(i).health != 0)
                    {
                        g.DrawImage(rightfish, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, swimmers.residents.ElementAt(i).Width, swimmers.residents.ElementAt(i).Height);
                        swimmers.residents.ElementAt(i).turn = false;
                    }
                    else
                    {
                        
                        g.DrawImage(rightdiefish, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, swimmers.residents.ElementAt(i).Width, swimmers.residents.ElementAt(i).Height);
                    }

                }
                else
                {
                    if (swimmers.residents.ElementAt(i).health != 0)
                    {
                        g.DrawImage(leftfish, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, 150, 95);
                    }
                    else
                    {
                        ///
                        g.DrawImage(leftdiefish, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, swimmers.residents.ElementAt(i).Width, swimmers.residents.ElementAt(i).Height);
                    }
                }
                DrawHealth(swimmers.residents.ElementAt(i).lifeRec, swimmers.residents.ElementAt(i).health);
            }
        }
        private void DrawMoveSnail(ListOfAquaPeople swimmers)
        {

            for (int i = 0; i < swimmers.residents.Count; i++)
            {
                if (swimmers.residents.ElementAt(i).Death)
                {
                    g.DrawImage(Image.FromFile("death.png"), swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, 150, 150);
                    swimmers.residents.RemoveAt(i);
                    continue;
                }
                if (swimmers.residents.ElementAt(i).turn)
                {
                    if (swimmers.residents.ElementAt(i).health != 0)
                    {
                        g.DrawImage(rightsnail, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, swimmers.residents.ElementAt(i).Width, swimmers.residents.ElementAt(i).Height);
                        swimmers.residents.ElementAt(i).turn = false;
                    }
                    else
                    {

                        g.DrawImage(leftdiesnail, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, swimmers.residents.ElementAt(i).Width, swimmers.residents.ElementAt(i).Height);
                    }

                }
                else
                {
                    if (swimmers.residents.ElementAt(i).health != 0)
                    {
                        g.DrawImage(leftsnail, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, 150, 95);
                    }
                    else
                    {
                        g.DrawImage(leftdiesnail, swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, swimmers.residents.ElementAt(i).Width, swimmers.residents.ElementAt(i).Height);
                    }
                }
                DrawHealth(swimmers.residents.ElementAt(i).lifeRec, swimmers.residents.ElementAt(i).health);
            }
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

        public void DrawFood(List<Food> eda)
        {
            foreach (Food food in eda)
                foreach (Food.Kroshka kpoxa in food.Korm)
                    g.DrawImage(Image.FromFile("kroshka.png"), kpoxa.x, kpoxa.y, 12, 12);
        }
    }
}
