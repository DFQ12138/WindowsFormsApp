using System;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class FontDialogForm : Form
    {
        public FontDialogForm()
        {
            InitializeComponent();
        }

        //“改变文本字体”按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //显示字体对话框
            DialogResult dr = fontDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
    }
}