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
        Aquarium world;
        Drawing draw;

        bool fishFlag,foodFlag;
        Graphics g;
        static Bitmap bmp;
        int x, y;
        int bigFISH = 0;


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
            if (!fishFlag && foodFlag)
            {
                world.CreateFood(x, y);
            }
            if (fishFlag)
            {   
                g.DrawImage(Image.FromFile("background.png"), 0, 0);
                world.Add(new FishAdult(g, MousePosition.X, MousePosition.Y));
                BackgroundImage = bmp;
                fishFlag = false;
            }
            
        }

        private void включитьАквариумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodFlag = true;
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);
            g.DrawImage(Image.FromFile("background.png"), 0, 0);
            BackgroundImage = bmp;
            world = new Aquarium();
            timer1.Enabled = true;
            включитьАквариумToolStripMenuItem.Enabled = false;
            добавитьРыбуToolStripMenuItem.Enabled = true;
            draw = new Drawing();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            world.AllFish.SlowDie();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            world.AllFish.Move();
            world.FallFood();
            BackgroundImage = draw.DrawAll(world);
        }
    }
}
