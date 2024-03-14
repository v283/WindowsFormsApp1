using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "cutting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gether";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Differance";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 100);
            this.button4.TabIndex = 3;
            this.button4.Text = "DisUnk";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 676);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }



        public void Cutting(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Blue);

            Font font = new Font("Arial", 10, FontStyle.Bold); // Change font as needed
            string text = "A";
            string text1 = "B";


            // Draw a circle
            int circleX = 70;
            int circleY = 70;
            int circleRadius = 60;
            g.DrawEllipse(pen, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);

            // Draw an ellipse
            int ellipseX = 80;
            int ellipseY = 25;
            int ellipseWidth = 48;
            int ellipseHeight = 90;
            g.FillEllipse(brush, ellipseX, ellipseY, ellipseWidth, ellipseHeight);
            g.DrawEllipse(pen, ellipseX, ellipseY, ellipseWidth, ellipseHeight);

            int circleX1 = 140;
            int circleY1 = 70;
            int circleRadius1 = 60;
            g.DrawEllipse(pen, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);

            // Draw text inside the circle
            SizeF textSize = g.MeasureString(text, font);
            PointF textPosition = new PointF(circleX - textSize.Width / 2, circleY - textSize.Height / 2);
            g.DrawString(text, font, Brushes.Black, textPosition);
            PointF textPosition1 = new PointF(circleX1 - textSize.Width / 2, circleY1 - textSize.Height / 2);
            g.DrawString(text1, font, Brushes.Black, textPosition1);
        }
        public void Gether(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 4);
            SolidBrush brush = new SolidBrush(Color.Blue);

            Font font = new Font("Arial", 10, FontStyle.Bold); // Change font as needed
            string text = "A";
            string text1 = "B";

            // Draw a circle
            int circleX = 70;
            int circleY = 70;
            int circleRadius = 60;
            g.DrawEllipse(pen, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);
            g.FillEllipse(brush, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);

            // Draw an ellipse

            int circleX1 = 140;
            int circleY1 = 70;
            int circleRadius1 = 60;
            g.DrawEllipse(pen, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);
            g.FillEllipse(brush, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);

            // Draw text inside the circle
            SizeF textSize = g.MeasureString(text, font);
            PointF textPosition = new PointF(circleX - textSize.Width / 2, circleY - textSize.Height / 2);
            g.DrawString(text, font, Brushes.White, textPosition);
            PointF textPosition1 = new PointF(circleX1 - textSize.Width / 2, circleY1 - textSize.Height / 2);
            g.DrawString(text1, font, Brushes.White, textPosition1);
        }

        public void Differance(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Blue);
            SolidBrush brush1 = new SolidBrush(Color.White);

            Font font = new Font("Arial", 10, FontStyle.Bold); // Change font as needed
            string text = "A";
            string text1 = "B";


            // Draw a circle
            int circleX = 70;
            int circleY = 70;
            int circleRadius = 60;
            g.DrawEllipse(pen, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);
            g.FillEllipse(brush, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);


            int circleX1 = 140;
            int circleY1 = 70;
            int circleRadius1 = 60;
            g.DrawEllipse(pen, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);
            g.FillEllipse(brush1, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);

            // Draw text inside the circle
            SizeF textSize = g.MeasureString(text, font);
            PointF textPosition = new PointF(circleX - textSize.Width / 2, circleY - textSize.Height / 2);
            g.DrawString(text, font, Brushes.White, textPosition);
            PointF textPosition1 = new PointF(circleX1 - textSize.Width / 2, circleY1 - textSize.Height / 2);
            g.DrawString(text1, font, Brushes.Black, textPosition1);

            // Draw an ellipse
            int ellipseX = 80;
            int ellipseY = 25;
            int ellipseWidth = 48;
            int ellipseHeight = 90;
            g.FillEllipse(brush1, ellipseX, ellipseY, ellipseWidth, ellipseHeight);
            g.DrawEllipse(pen, ellipseX, ellipseY, ellipseWidth, ellipseHeight);
        }

        public void Disunk( PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Blue);
            SolidBrush brush1 = new SolidBrush(Color.White);

            Font font = new Font("Arial", 10, FontStyle.Bold); // Change font as needed
            string text = "A";
            string text1 = "B";


            // Draw a circle
            int circleX = 70;
            int circleY = 70;
            int circleRadius = 60;
            g.DrawEllipse(pen, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);
            g.FillEllipse(brush, circleX - circleRadius, circleY - circleRadius, 2 * circleRadius, 2 * circleRadius);


            int circleX1 = 140;
            int circleY1 = 70;
            int circleRadius1 = 60;
            g.DrawEllipse(pen, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);
            g.FillEllipse(brush, circleX1 - circleRadius1, circleY1 - circleRadius1, 2 * circleRadius1, 2 * circleRadius1);

            // Draw text inside the circle
            SizeF textSize = g.MeasureString(text, font);
            PointF textPosition = new PointF(circleX - textSize.Width / 2, circleY - textSize.Height / 2);
            g.DrawString(text, font, Brushes.White, textPosition);
            PointF textPosition1 = new PointF(circleX1 - textSize.Width / 2, circleY1 - textSize.Height / 2);
            g.DrawString(text1, font, Brushes.White, textPosition1);

            // Draw an ellipse
            int ellipseX = 80;
            int ellipseY = 25;
            int ellipseWidth = 48;
            int ellipseHeight = 90;
            g.FillEllipse(brush1, ellipseX, ellipseY, ellipseWidth, ellipseHeight);
            g.DrawEllipse(pen, ellipseX, ellipseY, ellipseWidth, ellipseHeight);
        }
        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

