
using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm {
  public partial class FormMain : Form
  {
    private readonly OrderContext db = new OrderContext();
    OrderService orderService;
    BindingSource bdsFields = new BindingSource();
    public Action<FormEdit> ShowEditForm { get; set; }
    public String Keyword { get; set; }

    public FormMain() {
      InitializeComponent();
      orderService = new OrderService();
      var query = db.Orders.Include("Customer").Include(o=>o.details.Select(d=>d.GoodsItem));
      foreach (var order in query)
      {
        orderService.AddOrder(order);
      }
      bdsOrders.DataSource = orderService.Orders;
      cbxField.SelectedIndex = 0;
      txtKeyword.DataBindings.Add("Text", this, "Keyword");
    }
    private void btnAdd_Click(object sender, EventArgs e) {
      FormEdit formEdit = new FormEdit(new Order(),false,orderService);
      ShowEditForm(formEdit);
    }

    public void QueryAll()
    {
      db.SaveChanges();
      db.Orders.Load();
      bdsOrders.DataSource = db.Orders.Local.ToBindingList();
      bdsOrders.ResetBindings(false);
    }

    private void btnModify_Click(object sender, EventArgs e) {
      EditOrder();
    }
    private void dbvOrders_DoubleClick(object sender, EventArgs e) {
      EditOrder();
    }
    private void EditOrder() {
      Order order = bdsOrders.Current as Order;
      if (order == null) {
        MessageBox.Show("请选择一个订单进行修改");
        return;
      }
      FormEdit form2 = new FormEdit(order, true,orderService);
      ShowEditForm(form2);
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      Order order = bdsOrders.Current as Order;
      if (order == null) {
        MessageBox.Show("请选择一个订单进行删除");
        return;
      }
      orderService.RemoveOrder(order.OrderId);
      db.Orders.Remove(order);
      db.SaveChanges();
      QueryAll();
    }

    private void btnExport_Click(object sender, EventArgs e) {
      DialogResult result = saveFileDialog1.ShowDialog();
      if (result.Equals(DialogResult.OK)) {
        String fileName = saveFileDialog1.FileName;
        orderService.Export(fileName);
      }
    }

    private void btnImport_Click(object sender, EventArgs e) {
      DialogResult result = openFileDialog1.ShowDialog();
      if (result.Equals(DialogResult.OK)) {
        String fileName = openFileDialog1.FileName;
        orderService.Import(fileName);
        QueryAll();
      }
    }

    private void btnQuery_Click(object sender, EventArgs e)
    {
      db.SaveChanges();
      switch (cbxField.SelectedIndex) {
        case 0://所有订单
          bdsOrders.DataSource = orderService.Orders;
          bdsOrders.ResetBindings(false);
          // db.Orders.Load();
          // var results0 = db.Orders.Local.ToBindingList();
          // bdsOrders.DataSource = results0;
          // bdsOrders.ResetBindings(false);
          break;
        case 1://根据ID查询
          int.TryParse(Keyword, out int id);
          Order order = orderService.GetOrder(id);
          List<Order> result = new List<Order>();
          if (order != null) result.Add(order);
          bdsOrders.DataSource = result;
          // db.Orders.Load();
          // var results1_order = db.Orders.Where(o => o.OrderId == id);
          // var results1_detail = db.OrderDetails.Where(d => d.OrderId == id);
          // Order selectedOrder = results1_order.First();
          // foreach (var detail in results1_detail)
          // {
          //   selectedOrder.Details.Add(detail);
          // }
          //
          // List<Order> result1 = new List<Order>();
          // result1.Add(selectedOrder);
          // bdsOrders.DataSource = result1;
          bdsOrders.ResetBindings(false);
          break;
        case 2://根据客户查询
          bdsOrders.DataSource =orderService.QueryOrdersByCustomerName(Keyword);
          // db.Orders.Load();
          // var results2 = db.Orders.Where(o => o.Customer.Name == Keyword);
          // bdsOrders.DataSource = results2.ToList();
          bdsOrders.ResetBindings(false);
          break;
      }
      bdsOrders.ResetBindings(false);

    }
    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      base.OnClosing(e);
      db.Dispose();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      
    }
  }
}
