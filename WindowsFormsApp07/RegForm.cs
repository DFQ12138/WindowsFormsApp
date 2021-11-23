using System;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pwd = textBox2.Text;
            string repwd = textBox3.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            else if (!textBox2.Text.Equals(textBox3.Text))
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }

            //将用户名和密码传递到主窗体中
            MainForm mainForm = new MainForm(name, pwd);
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}