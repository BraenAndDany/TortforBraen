using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tort
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Black);
            g.FillRectangle(Brushes.BurlyWood, 300, 300, 200, 50);
            g.FillRectangle(Brushes.Pink, 295, 280, 210, 30);
            g.FillRectangle(Brushes.BurlyWood, 300, 240, 200, 40);
            g.FillRectangle(Brushes.Pink, 295, 210, 210, 30);
            g.FillRectangle(Brushes.BurlyWood, 300, 170, 200, 40);
            g.FillRectangle(Brushes.White, 290, 150, 220, 20);
            g.FillRectangle(Brushes.White, 290, 150, 10, 50);
            g.FillRectangle(Brushes.White, 320, 150, 10, 60);
            g.FillRectangle(Brushes.White, 350, 150, 10, 70);
            g.FillRectangle(Brushes.White, 350, 150, 30, 30);
            g.FillRectangle(Brushes.White, 300, 150, 20, 30);
            g.FillRectangle(Brushes.White, 370, 150, 10, 60);
            g.FillRectangle(Brushes.White, 390, 150, 10, 50);
            g.FillRectangle(Brushes.White, 400, 150, 20, 30);
            g.FillRectangle(Brushes.White, 430, 150, 10, 70);
            g.FillRectangle(Brushes.White, 450, 150, 10, 70);
            g.FillRectangle(Brushes.White, 460, 150, 30, 30);
            g.FillRectangle(Brushes.White, 480, 150, 20, 30);
            g.FillRectangle(Brushes.White, 480, 150, 10, 70);
            g.FillRectangle(Brushes.Red, 320, 130, 20, 20);
            g.FillRectangle(Brushes.Red, 360, 130, 20, 20);
            g.FillRectangle(Brushes.Red, 420, 130, 20, 20);
            g.FillRectangle(Brushes.Red, 460, 130, 20, 20);
            g.FillRectangle(Brushes.Gray, 395, 70, 10, 80);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Visible = true; 
            pictureBox2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Show();
        }
    }
}
