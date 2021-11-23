using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if ("dfq".Equals(username) && "123456".Equals(password))
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }
    }
}