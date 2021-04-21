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
    public partial class AddMessageBox : Form
    {
        public Order order_to_be_added = new Order();
        public List<OrderDetail> orderDetails = new List<OrderDetail>();

        public AddMessageBox()
        {
            InitializeComponent();
            this.label5.Text = "0";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new AddGoodsMessageBox();
            form.ShowDialog();
            orderDetails.Add(form.detail);
            this.label5.Text = orderDetails.Count.ToString();
            MessageBox.Show("添加成功");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            int orderId;
            uint customerId;
            string customerName;
            try
            {
                orderId = Convert.ToInt32(textBox1.Text);
                customerId = Convert.ToUInt32(textBox2.Text);
                customerName = textBox3.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("无效输入");
                return;
            }
            order_to_be_added.Id = orderId;
            order_to_be_added.Customer = new Customer(customerId, customerName);
            order_to_be_added.Details = orderDetails;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            orderDetails.RemoveAt(orderDetails.Count - 1);
            this.label5.Text = orderDetails.Count.ToString();
            MessageBox.Show("删除成功");
        }
        
    }
}
