using System;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                msg = msg + " " + listBox1.SelectedItems[i].ToString();
            }

            if (msg != "")
            {
                MessageBox.Show("您选择的爱好是：" + msg, "提示");
            }
            else
            {
                MessageBox.Show("您没有选择爱好", "提示");
            }
        }
    }
}