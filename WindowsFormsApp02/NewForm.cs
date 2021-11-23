using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        //窗体的鼠标单击事件
        private void NewForm_MouseClick(object sender, MouseEventArgs e)
        {
            //将窗体居中
            this.CenterToScreen();
        }

        //窗体的鼠标双击事件
        private void NewForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //关闭窗体
            this.Close();
        }
    }
}