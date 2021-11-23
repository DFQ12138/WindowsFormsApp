using System.ComponentModel;

namespace WindowsFormsApp16
{
    partial class ContextMenuStrip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.打开窗体ToolStripMenuItem, this.关闭窗体ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 82);
            // 
            // 打开窗体ToolStripMenuItem
            // 
            this.打开窗体ToolStripMenuItem.Name = "打开窗体ToolStripMenuItem";
            this.打开窗体ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.打开窗体ToolStripMenuItem.Text = "打开窗体";
            this.打开窗体ToolStripMenuItem.Click += new System.EventHandler(this.打开窗体ToolStripMenuItem_Click);
            // 
            // 关闭窗体ToolStripMenuItem
            // 
            this.关闭窗体ToolStripMenuItem.Name = "关闭窗体ToolStripMenuItem";
            this.关闭窗体ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.关闭窗体ToolStripMenuItem.Text = "关闭窗体";
            this.关闭窗体ToolStripMenuItem.Click += new System.EventHandler(this.关闭窗体ToolStripMenuItem_Click);
            // 
            // ContextMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "ContextMenuStrip";
            this.Text = "ContextMenuStrip";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem 打开窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭窗体ToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        #endregion
    }
}