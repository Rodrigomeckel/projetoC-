﻿namespace WindowsFormsApplication15
{
    partial class QUIZGEOGRAFIA1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUIZGEOGRAFIA1));
            this.iNICIARQUIZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNICIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iNICIARQUIZToolStripMenuItem
            // 
            this.iNICIARQUIZToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iNICIARQUIZToolStripMenuItem.BackgroundImage")));
            this.iNICIARQUIZToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIARToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.iNICIARQUIZToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNICIARQUIZToolStripMenuItem.ForeColor = System.Drawing.Color.Transparent;
            this.iNICIARQUIZToolStripMenuItem.Name = "iNICIARQUIZToolStripMenuItem";
            this.iNICIARQUIZToolStripMenuItem.Size = new System.Drawing.Size(177, 34);
            this.iNICIARQUIZToolStripMenuItem.Text = "---INICIAR QUIZ";
            this.iNICIARQUIZToolStripMenuItem.Click += new System.EventHandler(this.iNICIARQUIZToolStripMenuItem_Click);
            // 
            // iNICIARToolStripMenuItem
            // 
            this.iNICIARToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iNICIARToolStripMenuItem.Name = "iNICIARToolStripMenuItem";
            this.iNICIARToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.iNICIARToolStripMenuItem.Text = "INICIAR";
            this.iNICIARToolStripMenuItem.Click += new System.EventHandler(this.iNICIARToolStripMenuItem_Click_1);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIARQUIZToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QUIZGEOGRAFIA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 497);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QUIZGEOGRAFIA1";
            this.Text = "QUIZGEOGRAFIA1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem iNICIARQUIZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNICIARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}