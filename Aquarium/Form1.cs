using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Aquarium2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BL.Aquarium world;
        Drawing draw;

        bool fishFlag,foodFlag, snailFlag;
        Graphics g;
        static Bitmap bmp;
        int x, y;
        int bigFISH = 0;
        int snail = 0;


        private void рыбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fishFlag = true;
            bigFISH++;
            рыбуToolStripMenuItem.Text = "Рыбу " + bigFISH.ToString() + "/3";
            if (bigFISH == 3)
            {
                рыбуToolStripMenuItem.Text = "Больше нельзя ;(";
                рыбуToolStripMenuItem.Enabled = false;
            }
            if (bigFISH == 1)
                timer2.Enabled = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            x = MousePosition.X;
            y = MousePosition.Y;
            if (!fishFlag && foodFlag && y <= 630)
            {
                world.CreateFood(x, y);
            }
            if (fishFlag)
            {   
                g.DrawImage(Image.FromFile("background.png"), 0, 0);
                world.AddFish(new FishAdult(g, MousePosition.X, MousePosition.Y));
                BackgroundImage = bmp;
                fishFlag = false;
            }
            if (snailFlag && y > 630)
            {
                g.DrawImage(Image.FromFile("background.png"), 0, 0);
                world.AddSnail(new Snail(g, MousePosition.X, MousePosition.Y));
                BackgroundImage = bmp;
                snailFlag = false;
            }
            else
                snail--;
            
            
        }

        private void включитьАквариумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodFlag = true;
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);
            g.DrawImage(Image.FromFile("background.png"), 0, 0);
            BackgroundImage = bmp;
            world = new BL.Aquarium();
            timer1.Enabled = true;
            включитьАквариумToolStripMenuItem.Enabled = false;
            добавитьToolStripMenuItem.Enabled = true;
            draw = new Drawing();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          
        }

        private void улиткуToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
                snailFlag = true;
                snail++;
               // улиткуToolStripMenuItem.Text = "Улитку " + snail.ToString() + "/4";
                if (snail == 4)
                {
                    улиткуToolStripMenuItem.Text = "Больше нельзя ;(";
                    улиткуToolStripMenuItem.Enabled = false;
                }
                if (snail == 1)
                    timer2.Enabled = true;
           
        }
    


        private void timer2_Tick(object sender, EventArgs e)
        {
            world.AllFish.SlowDie();
            world.AllSnail.SlowDie();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            world.AllSnail.Move();
            world.AllFish.Move();
            world.FallFood();
            BackgroundImage = draw.DrawAll(world);
        }
    }
}
