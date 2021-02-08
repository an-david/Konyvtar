namespace Konyvtar
{
    partial class Form1
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
            this.könyvFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.könyvTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.könyvBeszerzésénekBeviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.könyvKereséseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gyüjteményToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.könyvFelvételeToolStripMenuItem,
            this.könyvTörléseToolStripMenuItem,
            this.könyvBeszerzésénekBeviteleToolStripMenuItem,
            this.könyvKereséseToolStripMenuItem,
            this.gyüjteményToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // könyvFelvételeToolStripMenuItem
            // 
            this.könyvFelvételeToolStripMenuItem.Name = "könyvFelvételeToolStripMenuItem";
            this.könyvFelvételeToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.könyvFelvételeToolStripMenuItem.Text = "Könyv felvétele";
            this.könyvFelvételeToolStripMenuItem.Click += new System.EventHandler(this.könyvFelvételeToolStripMenuItem_Click);
            // 
            // könyvTörléseToolStripMenuItem
            // 
            this.könyvTörléseToolStripMenuItem.Name = "könyvTörléseToolStripMenuItem";
            this.könyvTörléseToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.könyvTörléseToolStripMenuItem.Text = "Könyv törlése";
            this.könyvTörléseToolStripMenuItem.Click += new System.EventHandler(this.könyvTörléseToolStripMenuItem_Click);
            // 
            // könyvBeszerzésénekBeviteleToolStripMenuItem
            // 
            this.könyvBeszerzésénekBeviteleToolStripMenuItem.Name = "könyvBeszerzésénekBeviteleToolStripMenuItem";
            this.könyvBeszerzésénekBeviteleToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.könyvBeszerzésénekBeviteleToolStripMenuItem.Text = "Könyv beszerzésének bevitele";
            this.könyvBeszerzésénekBeviteleToolStripMenuItem.Click += new System.EventHandler(this.könyvBeszerzésénekBeviteleToolStripMenuItem_Click);
            // 
            // könyvKereséseToolStripMenuItem
            // 
            this.könyvKereséseToolStripMenuItem.Name = "könyvKereséseToolStripMenuItem";
            this.könyvKereséseToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.könyvKereséseToolStripMenuItem.Text = "Könyv keresése";
            this.könyvKereséseToolStripMenuItem.Click += new System.EventHandler(this.könyvKereséseToolStripMenuItem_Click);
            // 
            // gyüjteményToolStripMenuItem
            // 
            this.gyüjteményToolStripMenuItem.Name = "gyüjteményToolStripMenuItem";
            this.gyüjteményToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.gyüjteményToolStripMenuItem.Text = "Gyűjtemény";
            this.gyüjteményToolStripMenuItem.Click += new System.EventHandler(this.gyüjteményToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Könyvtár";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem könyvFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem könyvTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem könyvBeszerzésénekBeviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem könyvKereséseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gyüjteményToolStripMenuItem;
    }
}

