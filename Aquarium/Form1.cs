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

        ListOfAquaPeople swimmers;
        bool fishFlag;
        Graphics g;
        static Bitmap bmp;// = new Bitmap(Image.FromFile("background.png"));
        //static Graphics g = Graphics.FromHwnd()//Graphics.FromImage(bmp);
        int x, y;


        private void рыбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fishFlag = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {

            if (fishFlag)
            {
                x = MousePosition.X;
                y = MousePosition.Y;
                //bmp = new Bitmap(Width, Height);
                //g = Graphics.FromImage(bmp);
                g.DrawImage(Image.FromFile("background.png"), 0, 0);
                //Graphics g = Graphics.FromHwnd(Handle);
                swimmers.Add(new FishAdult(g, MousePosition.X, MousePosition.Y));
                BackgroundImage = bmp;
                fishFlag = false;
            }
        }

        private void включитьАквариумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);
            g.DrawImage(Image.FromFile("background.png"), 0, 0);
            BackgroundImage = bmp;
            swimmers = new ListOfAquaPeople();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            swimmers.Move();
            BackgroundImage = swimmers.BM();
        }
    }
}
