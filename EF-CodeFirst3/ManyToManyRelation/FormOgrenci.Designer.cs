namespace ManyToManyRelation
{
    partial class FormOgrenci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1Ad = new System.Windows.Forms.Label();
            this.label2Soyad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1Ad
            // 
            this.label1Ad.AutoSize = true;
            this.label1Ad.Location = new System.Drawing.Point(377, 102);
            this.label1Ad.Name = "label1Ad";
            this.label1Ad.Size = new System.Drawing.Size(23, 13);
            this.label1Ad.TabIndex = 1;
            this.label1Ad.Text = "Ad:";
            // 
            // label2Soyad
            // 
            this.label2Soyad.AutoSize = true;
            this.label2Soyad.Location = new System.Drawing.Point(377, 184);
            this.label2Soyad.Name = "label2Soyad";
            this.label2Soyad.Size = new System.Drawing.Size(40, 13);
            this.label2Soyad.TabIndex = 2;
            this.label2Soyad.Text = "Soyad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(524, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(524, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1_Ekle
            // 
            this.button1_Ekle.Location = new System.Drawing.Point(549, 226);
            this.button1_Ekle.Name = "button1_Ekle";
            this.button1_Ekle.Size = new System.Drawing.Size(75, 23);
            this.button1_Ekle.TabIndex = 5;
            this.button1_Ekle.Text = "Ekle";
            this.button1_Ekle.UseVisualStyleBackColor = true;
            this.button1_Ekle.Click += new System.EventHandler(this.button1_Ekle_Click);
            // 
            // FormOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Ekle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2Soyad);
            this.Controls.Add(this.label1Ad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormOgrenci";
            this.Text = "FormOgrenci";
            this.Load += new System.EventHandler(this.FormOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1Ad;
        private System.Windows.Forms.Label label2Soyad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1_Ekle;
    }
}