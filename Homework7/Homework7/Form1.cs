using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox_color.SelectedIndex = 0;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            else
            {
                graphics.Clear(this.BackColor);
            }

            int n = 10;
            double leng = 100;

            try
            {
                if (textBox_n.Text != "") n = Convert.ToInt32(textBox_n.Text);
                if (textBox_leng.Text != "") leng = Convert.ToDouble(textBox_leng.Text);
                if (textBox_per1.Text != "") this.per1 = Convert.ToDouble(textBox_per1.Text);
                if (textBox_per2.Text != "") this.per2 = Convert.ToDouble(textBox_per2.Text);
                if (textBox_th1.Text != "") this.th1 = Convert.ToDouble(textBox_th1.Text);
                if (textBox_th2.Text != "") this.th2 = Convert.ToDouble(textBox_th2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input!");
                return;
            }

            drawCayleyTree(n, this.Size.Width / 2, (this.Size.Height - panel1.Size.Height) / 1.5, leng, -Math.PI / 2);
        }

        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

            void drawLine(double x0, double y0, double x1, double y1)
            {
                string color = comboBox_color.Text;
                switch (color)
                {
                    case "Red":
                        graphics.DrawLine(Pens.Red, (int) x0, (int) y0, (int) x1, (int) y1);
                        break;

                    case "Yellow":
                        graphics.DrawLine(Pens.Yellow, (int) x0, (int) y0, (int) x1, (int) y1);
                        break;

                    case "Blue":
                        graphics.DrawLine(Pens.Blue, (int) x0, (int) y0, (int) x1, (int) y1);
                        break;

                    case "Black":
                        graphics.DrawLine(Pens.Black, (int) x0, (int) y0, (int) x1, (int) y1);
                        break;

                    default:
                        graphics.DrawLine(Pens.Blue, (int) x0, (int) y0, (int) x1, (int) y1);
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}