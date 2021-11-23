using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            //弹出消息框，并获取消息框的返回值
            DialogResult dr = MessageBox.Show("是否打开新窗体？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //如果消息框返回值是Yes，显示新窗体
            if (dr == DialogResult.Yes)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.Show();
            }
            //如果消息框返回值是No，关闭当前窗体
            else if (dr == DialogResult.No)
            {
                //关闭当前窗体
                this.Close();
            }
        }
    }
}