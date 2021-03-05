using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (num1.Text != "")
            {
                a = Convert.ToInt32(num1.Text);
            }

            if (num2.Text != "")
            {
                b = Convert.ToInt32(num2.Text);
            }

            int ans = 0;

            switch (Convert.ToChar(opBox.Text))
            {
                case '+':
                    ans = a + b;
                    break;
                case '-':
                    ans = a - b;
                    break;
                case '*':
                    ans = a * b;
                    break;
                case '/':
                    ans = a / b;
                    break;
                default:
                    ans = 0;
                    break;
            }

            ansLabel.Text = ans.ToString();
        }
    }
}