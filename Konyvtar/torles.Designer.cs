namespace Konyvtar
{
    partial class torles
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.konyv_torles_id = new System.Windows.Forms.NumericUpDown();
            this.bt_vissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konyv_torles_id)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 435);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Könyv azonosító:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Könyv törlése az adatbázisból";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // konyv_torles_id
            // 
            this.konyv_torles_id.Location = new System.Drawing.Point(556, 116);
            this.konyv_torles_id.Name = "konyv_torles_id";
            this.konyv_torles_id.Size = new System.Drawing.Size(120, 20);
            this.konyv_torles_id.TabIndex = 5;
            // 
            // bt_vissza
            // 
            this.bt_vissza.Location = new System.Drawing.Point(713, 6);
            this.bt_vissza.Name = "bt_vissza";
            this.bt_vissza.Size = new System.Drawing.Size(75, 23);
            this.bt_vissza.TabIndex = 6;
            this.bt_vissza.Text = "Vissza";
            this.bt_vissza.UseVisualStyleBackColor = true;
            this.bt_vissza.Click += new System.EventHandler(this.bt_vissza_Click);
            // 
            // torles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_vissza);
            this.Controls.Add(this.konyv_torles_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "torles";
            this.Text = "Fénykép törlése";
            this.Load += new System.EventHandler(this.torles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konyv_torles_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown konyv_torles_id;
        private System.Windows.Forms.Button bt_vissza;
    }
}