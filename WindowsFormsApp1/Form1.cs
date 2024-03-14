using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool drawCutting = false;
        private bool drawGether = false;
        private bool drawDifferance = false;
        private bool drawDisunk = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawDisunk = false;
            drawCutting = true;
            drawGether = false;
            drawDifferance = false;
            Invalidate(); // Redraw the form
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            if (drawDisunk )
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                Disunk(e);
            }
            else if (drawCutting)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                Cutting(e);
            }
            else if (drawDifferance)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                Differance(e);
            }
            else if (drawGether)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                Gether(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawDisunk = false;
            drawCutting = false;
            drawGether = true;
            drawDifferance = false;
            Invalidate(); // Redraw the form
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawDisunk = false;
            drawCutting = false;
            drawGether = false;
            drawDifferance = true;
            Invalidate(); // Redraw the form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawDisunk = true;
            drawCutting = false;
            drawGether = false;
            drawDifferance = false;
            Invalidate(); // Redraw the form
        }
    }
}
