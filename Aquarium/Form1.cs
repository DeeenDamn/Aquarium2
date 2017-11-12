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

        ListOfAquaPeople swimmers = new ListOfAquaPeople();
        bool fishFlag;
        static Bitmap bmp = new Bitmap(Image.FromFile("background.png"));
        //static Graphics g = Graphics.FromHwnd()//Graphics.FromImage(bmp);



        private void рыбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fishFlag = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {

            if (fishFlag)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                swimmers.Add(new FishAdult(g, MousePosition.X, MousePosition.Y));
                fishFlag = false;
            }
        }

    }
}
