using System;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class ColorDialogForm : Form
    {
        public ColorDialogForm()
        {
            InitializeComponent();
        }

        //“更改文本颜色”按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //显示颜色对话框
            DialogResult dr = colorDialog1.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}