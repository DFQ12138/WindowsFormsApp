using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class MainForm : Form
    {
        public MainForm(string name,string pwd)
        {
            InitializeComponent();
            label2.Text = "用户名："+ name;
            label3.Text = "密  码："+pwd;
        }
    }
}