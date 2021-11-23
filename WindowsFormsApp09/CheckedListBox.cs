using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class CheckedListBox : Form
    {
        public CheckedListBox()
        {
            InitializeComponent();
        }

        //“购买”按钮的点击事件，用于在消息框中显示购买的水果种类
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";


            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                msg = msg + checkedListBox1.CheckedItems[i].ToString() + " ";
            }

            if (msg != "")
            {
                MessageBox.Show("您购买的水果有：" + msg, "提示");
            }
            else
            {
                MessageBox.Show("您没有选购水果！", "提示");
            }
        }
    }
}