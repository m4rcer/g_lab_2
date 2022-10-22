using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace g_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            graphPictureBox.BackColor = Color.FromKnownColor(KnownColor.Info);
        }

        private void DrawGrid(Graphics g, Pen pen)
        {
            DrawRectangle(g, pen);
            DrawAxes(g, pen);
        }

        private void DrawRectangle(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, 0, 0, graphPictureBox.Size.Width -1, graphPictureBox.Size.Height - 1);
        }

        private void DrawAxes(Graphics g, Pen pen)
        {
            g.DrawLine(pen,
                graphPictureBox.Size.Width / 2, 0,
                graphPictureBox.Size.Width / 2, graphPictureBox.Size.Height);
            g.DrawLine(pen,
                0, graphPictureBox.Size.Height / 2,
                graphPictureBox.Size.Width, graphPictureBox.Size.Height / 2);
        }

        private void DrawChart(Graphics g, Pen pen, double minX, double maxX, Func<double, double> function)
        {

            List<PointF> points = new List<PointF>();

            for (double step = minX, i = 0; step < maxX; step += 0.01, i++)
            {
                double x = (step * 50) + (int)(graphPictureBox.Size.Width / 2);
                double tmp = function(step);
                tmp *= 100;
                double y = (int)(graphPictureBox.Size.Height / 2) - tmp;
                points.Add(new PointF((float)x, (float)y));
            }

            g.DrawLines(pen, points.ToArray());
        }

        private void Draw(GraphicsUnit pageUnit)
        {
            Pen redPen = new Pen(Color.Red, 1);
            Pen greenPen = new Pen(Color.Blue, 1);
            Graphics g = graphPictureBox.CreateGraphics();
            g.PageUnit = pageUnit;
            Func<double, double> function = x => Math.Sin(x);
            DrawGrid(g, redPen);
            DrawChart(g, greenPen, -2.5 * Math.PI, 2.5 * Math.PI, function);

            g.Dispose();
        }

        private void pixelsButton_Click(object sender, EventArgs e)
        {
            Draw(GraphicsUnit.Pixel);
        }

        private void millemetersButton_Click(object sender, EventArgs e)
        {
            Draw(GraphicsUnit.Millimeter);
        }

        private void inchesButton_Click(object sender, EventArgs e)
        {
            Draw(GraphicsUnit.Inch);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Graphics g = graphPictureBox.CreateGraphics();
            g.Clear(Color.FromKnownColor(KnownColor.Info));
            g.Dispose();
        }
    }
}
