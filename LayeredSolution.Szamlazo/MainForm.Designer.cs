﻿namespace LayeredSolution.Szamlazo
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendelésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékekToolStripMenuItem,
            this.rendelésekToolStripMenuItem,
            this.felhasználókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékekToolStripMenuItem
            // 
            this.termékekToolStripMenuItem.Name = "termékekToolStripMenuItem";
            this.termékekToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.termékekToolStripMenuItem.Text = "Termékek";
            this.termékekToolStripMenuItem.Click += new System.EventHandler(this.termékekToolStripMenuItem_Click);
            // 
            // rendelésekToolStripMenuItem
            // 
            this.rendelésekToolStripMenuItem.Name = "rendelésekToolStripMenuItem";
            this.rendelésekToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.rendelésekToolStripMenuItem.Text = "Rendelések";
            this.rendelésekToolStripMenuItem.Click += new System.EventHandler(this.rendelésekToolStripMenuItem_Click);
            // 
            // felhasználókToolStripMenuItem
            // 
            this.felhasználókToolStripMenuItem.Name = "felhasználókToolStripMenuItem";
            this.felhasználókToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.felhasználókToolStripMenuItem.Text = "Felhasználók";
            this.felhasználókToolStripMenuItem.Click += new System.EventHandler(this.felhasználókToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendelésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználókToolStripMenuItem;
    }
}

