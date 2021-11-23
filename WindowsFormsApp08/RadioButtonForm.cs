using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class RadioButtonForm : Form
    {
        public RadioButtonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (radioButton1.Checked)
            {
                msg = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                msg = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                msg = radioButton3.Text;
            }


            MessageBox.Show("您选择的权限是：" + msg, "提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}