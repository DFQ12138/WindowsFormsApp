using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class PictureBoxForm : Form
    {
        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定义中间变量存放图片地址，用于交换图片地址
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox.Image;
        }


        private void PictureBoxForm_Load(object sender, EventArgs e)
        {pictureBox1.Image = Image.FromFile(@"C:\\Users\\DOU\\Pictures\\2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"C:\\Users\\DOU\\Pictures\\2.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       
    }
}