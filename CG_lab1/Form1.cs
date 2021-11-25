using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab1
{
    public partial class Form1 : Form
    {
       Graphics g;
        List<Point> userp = new List<Point>();

       Pen pen = new Pen(System.Drawing.Color.Black, 3); 
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            Point[] points = userp.ToArray();
            g.DrawCurve(pen, points, (float)1);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            userp.Clear();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point();
            p = panel1.PointToClient(MousePosition);
            g.DrawEllipse(pen, p.X, p.Y, (float)0.01, (float)0.01);
            userp.Add(p);
        }
    }
}
