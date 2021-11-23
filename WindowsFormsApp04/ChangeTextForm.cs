using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ChangeTextForm : Form
    {
        public ChangeTextForm()
        {
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (label1.Text, label2.Text) = (label2.Text, label1.Text);
        }

    }
}