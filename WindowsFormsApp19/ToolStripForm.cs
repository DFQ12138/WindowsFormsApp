using System;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class ToolStripForm : Form
    {
        public ToolStripForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripForm tool = new ToolStripForm();
            tool.Show();
        }
    }
}