using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //创建NewForm 窗体实例
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            //创建NewForm窗体实例
            NewForm newForm = new NewForm();
            //打开NewForm窗体
            newForm.Show();
        }
    }
}