using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //设置窗体背景颜色为黑色
            this.BackColor = Color.Black;
            //throw new System.NotImplementedException();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //设置窗体背景颜色为蓝色
            this.BackColor = Color.Blue;
          //  throw new System.NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
           // throw new System.NotImplementedException();
        }
    }
}