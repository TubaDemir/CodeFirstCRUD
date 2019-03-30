namespace ManyToManyRelation
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
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ögrenciEgitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ögrenciToolStripMenuItem,
            this.egitmenToolStripMenuItem,
            this.ögrenciEgitmenToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // ögrenciToolStripMenuItem
            // 
            this.ögrenciToolStripMenuItem.Name = "ögrenciToolStripMenuItem";
            this.ögrenciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ögrenciToolStripMenuItem.Text = "Ögrenci";
            this.ögrenciToolStripMenuItem.Click += new System.EventHandler(this.ögrenciToolStripMenuItem_Click);
            // 
            // egitmenToolStripMenuItem
            // 
            this.egitmenToolStripMenuItem.Name = "egitmenToolStripMenuItem";
            this.egitmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.egitmenToolStripMenuItem.Text = "Egitmen";
            this.egitmenToolStripMenuItem.Click += new System.EventHandler(this.egitmenToolStripMenuItem_Click);
            // 
            // ögrenciEgitmenToolStripMenuItem
            // 
            this.ögrenciEgitmenToolStripMenuItem.Name = "ögrenciEgitmenToolStripMenuItem";
            this.ögrenciEgitmenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ögrenciEgitmenToolStripMenuItem.Text = "Ögrenci Egitmen";
            this.ögrenciEgitmenToolStripMenuItem.Click += new System.EventHandler(this.ögrenciEgitmenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ögrenciEgitmenToolStripMenuItem;
    }
}

