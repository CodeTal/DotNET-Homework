using System;
using System.Windows.Forms;

namespace Homework8
{
    public partial class DeleteMessageBox : Form
    {
        public int deleteID;
        public DeleteMessageBox()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                deleteID = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("无效输入");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}