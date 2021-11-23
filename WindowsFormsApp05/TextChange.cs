using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class TextChange : Form
    {
        public TextChange()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //将文本框中的文本值显示在标签中
            label1.Text = textBox1.Text;
        }
    }
}