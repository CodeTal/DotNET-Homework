using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordertest;

namespace Homework8
{
    public partial class AddGoodsMessageBox : Form
    {
        public OrderDetail detail = new OrderDetail();
        public AddGoodsMessageBox()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            int price = Convert.ToInt32(textBox3.Text);
            uint quantity = Convert.ToUInt32(textBox4.Text);
            detail = new OrderDetail(new Goods(id, name, price), quantity);
            MessageBox.Show("添加成功");
            this.Close();
        }
    }
}
