using System;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        //打开文件菜单项的单击事件
        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile f = new OpenFile();
            f.MdiParent = this;
            f.Show();
        }

        //保存文件菜单项单击事件
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile f = new SaveFile();
            f.MdiParent = this;
            f.Show();
        }

       
    }
}