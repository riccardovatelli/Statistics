using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics_C__Bitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Bitmap b;
        public Graphics g;

        private void Form1_Load(object sender, EventArgs e)
        {

            b = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            g = Graphics.FromImage(b);

            Pen pen = new Pen(Color.Red, 5);

            var font = new Font(FontFamily.GenericSerif, 30f, FontStyle.Bold);
            var brush = new SolidBrush(Color.Black);

            PointF start_point = new PointF(100.0F, 100.0F);
            PointF end_point = new PointF(200.0F, 200.0F);

            Rectangle r = new Rectangle(250, 50, 100, 150);

            g.DrawLine(pen, start_point, end_point);
            g.DrawEllipse(pen, 400, 50, 150, 150);
            g.FillEllipse(Brushes.DarkBlue, 425, 225, 100, 100);
            g.FillEllipse(Brushes.Black, 470, 10, 10, 10);
            g.DrawRectangle(pen, r);
            g.FillRectangle(Brushes.DarkRed, 150, 60, 50, 75);

            g.DrawString("Bitmap", font, brush, 50, -10);

            this.pictureBox1.Image = b;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}