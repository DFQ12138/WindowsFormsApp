using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class FileDialogForm : Form
    {
        public FileDialogForm()
        {
            InitializeComponent();
        }

        //打开文件
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            //获取所打开文件的文件名
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                StreamReader sr = new StreamReader(filename);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        //保存文件
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8);
                sw.Write(textBox1.Text);
                sw.Close();
            }
        }
    }
}