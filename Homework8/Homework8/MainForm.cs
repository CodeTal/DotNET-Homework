using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ordertest;

namespace Homework8
{
    public partial class MainForm : Form
    {
        public OrderService orderService = new OrderService();

        public MainForm()
        {
            InitializeComponent();

            this.dataGridView1.ReadOnly = true;

            Order order1 = new Order(1, new Customer(17, "Tom"));
            order1.AddDetails(new OrderDetail(new Goods(13, "pipe", 55), 30));

            Order order2 = new Order(2, new Customer(22, "David"));
            order2.AddDetails(new OrderDetail(new Goods(7, "banana", 4), 10));

            Order order3 = new Order(3, new Customer(51, "Bob"));
            order3.AddDetails(new OrderDetail(new Goods(51, "pork", 20), 22));

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            this.orderBindingSource.DataSource = orderService.orderList;
            this.dataGridView1.DataSource = orderBindingSource;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            string queryString = queryStringTextBox.Text;
            if (queryString == "")
            {
                orderBindingSource.DataSource = orderService.orderList;
                return;
            }
            List<Order> results = orderService.QueryByCustomerName(queryString);
            results.Union(orderService.QueryByGoodsName(queryString));
            orderBindingSource.DataSource = results;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Add")
            {
                var form = new AddMessageBox();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    orderBindingSource.Add(form.order_to_be_added);
                    orderBindingSource.DataSource = orderService.orderList;
                }
            }

            if (e.ClickedItem.Text == "Delete")
            {
                var form = new DeleteMessageBox();
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (Order order in orderBindingSource)
                    {
                        if (order.Id == form.deleteID)
                        {
                            orderBindingSource.Remove(order);
                            break;
                        }
                    }
                }
                orderBindingSource.DataSource = orderService.orderList;
            }
        }

        private void modifyMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModifyMessageBox();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                int modifyID = form.modifyID;
                bool flag = false;
                foreach (Order order in orderBindingSource)
                {
                    if (order.Id == form.modifyID)
                    {
                        orderBindingSource.Remove(order);
                        flag = true;
                        break;
                    }
                }

                if (flag == false) {
                    MessageBox.Show("不存在该项");
                    return;
                }

                orderBindingSource.Add(form.order_to_be_added);
                orderBindingSource.DataSource = orderService.orderList;
            }
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("data.xml",FileMode.Create))
            {
                xmlSerializer.Serialize(fs,orderService.orderList);
            }

            MessageBox.Show("保存成功");
        }

        private void importMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            try
            {
                using (FileStream fs = new FileStream("data.xml", FileMode.Open))
                {
                    orderService.orderList = (List<Order>) xmlSerializer.Deserialize(fs);
                    orderBindingSource.DataSource = orderService.orderList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取失败:文件未找到");
                return;
            }
            MessageBox.Show("读取成功");
        }
    }
}
