namespace Konyvtar
{
    partial class felvetel
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
            this.konyv_cim = new System.Windows.Forms.Label();
            this.konyv_szerzo = new System.Windows.Forms.Label();
            this.konyv_kiado = new System.Windows.Forms.Label();
            this.konyv_megj = new System.Windows.Forms.Label();
            this.konyv_mufaj = new System.Windows.Forms.Label();
            this.tb_konyvcim = new System.Windows.Forms.TextBox();
            this.tb_konyvszerzo = new System.Windows.Forms.TextBox();
            this.tb_konyvkiado = new System.Windows.Forms.TextBox();
            this.tb_konyvmegj = new System.Windows.Forms.TextBox();
            this.tb_konyvmufaj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_vissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 435);
            this.dataGridView1.TabIndex = 2;
            // 
            // konyv_cim
            // 
            this.konyv_cim.AutoSize = true;
            this.konyv_cim.Location = new System.Drawing.Point(500, 68);
            this.konyv_cim.Name = "konyv_cim";
            this.konyv_cim.Size = new System.Drawing.Size(29, 13);
            this.konyv_cim.TabIndex = 3;
            this.konyv_cim.Text = "Cím:";
            // 
            // konyv_szerzo
            // 
            this.konyv_szerzo.AutoSize = true;
            this.konyv_szerzo.Location = new System.Drawing.Point(500, 105);
            this.konyv_szerzo.Name = "konyv_szerzo";
            this.konyv_szerzo.Size = new System.Drawing.Size(42, 13);
            this.konyv_szerzo.TabIndex = 4;
            this.konyv_szerzo.Text = "Szerző:";
            // 
            // konyv_kiado
            // 
            this.konyv_kiado.AutoSize = true;
            this.konyv_kiado.Location = new System.Drawing.Point(500, 147);
            this.konyv_kiado.Name = "konyv_kiado";
            this.konyv_kiado.Size = new System.Drawing.Size(37, 13);
            this.konyv_kiado.TabIndex = 5;
            this.konyv_kiado.Text = "Kiadó:";
            // 
            // konyv_megj
            // 
            this.konyv_megj.AutoSize = true;
            this.konyv_megj.Location = new System.Drawing.Point(500, 192);
            this.konyv_megj.Name = "konyv_megj";
            this.konyv_megj.Size = new System.Drawing.Size(64, 13);
            this.konyv_megj.TabIndex = 6;
            this.konyv_megj.Text = "Megjelenés:";
            // 
            // konyv_mufaj
            // 
            this.konyv_mufaj.AutoSize = true;
            this.konyv_mufaj.Location = new System.Drawing.Point(500, 231);
            this.konyv_mufaj.Name = "konyv_mufaj";
            this.konyv_mufaj.Size = new System.Drawing.Size(36, 13);
            this.konyv_mufaj.TabIndex = 7;
            this.konyv_mufaj.Text = "Műfaj:";
            // 
            // tb_konyvcim
            // 
            this.tb_konyvcim.Location = new System.Drawing.Point(574, 65);
            this.tb_konyvcim.Name = "tb_konyvcim";
            this.tb_konyvcim.Size = new System.Drawing.Size(147, 20);
            this.tb_konyvcim.TabIndex = 8;
            // 
            // tb_konyvszerzo
            // 
            this.tb_konyvszerzo.Location = new System.Drawing.Point(574, 102);
            this.tb_konyvszerzo.Name = "tb_konyvszerzo";
            this.tb_konyvszerzo.Size = new System.Drawing.Size(147, 20);
            this.tb_konyvszerzo.TabIndex = 9;
            // 
            // tb_konyvkiado
            // 
            this.tb_konyvkiado.Location = new System.Drawing.Point(574, 144);
            this.tb_konyvkiado.Name = "tb_konyvkiado";
            this.tb_konyvkiado.Size = new System.Drawing.Size(147, 20);
            this.tb_konyvkiado.TabIndex = 10;
            // 
            // tb_konyvmegj
            // 
            this.tb_konyvmegj.Location = new System.Drawing.Point(574, 189);
            this.tb_konyvmegj.Name = "tb_konyvmegj";
            this.tb_konyvmegj.Size = new System.Drawing.Size(147, 20);
            this.tb_konyvmegj.TabIndex = 11;
            // 
            // tb_konyvmufaj
            // 
            this.tb_konyvmufaj.Location = new System.Drawing.Point(574, 231);
            this.tb_konyvmufaj.Name = "tb_konyvmufaj";
            this.tb_konyvmufaj.Size = new System.Drawing.Size(147, 20);
            this.tb_konyvmufaj.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Könyv felvétele az adatbázisba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_vissza
            // 
            this.bt_vissza.Location = new System.Drawing.Point(713, 8);
            this.bt_vissza.Name = "bt_vissza";
            this.bt_vissza.Size = new System.Drawing.Size(75, 23);
            this.bt_vissza.TabIndex = 14;
            this.bt_vissza.Text = "Vissza";
            this.bt_vissza.UseVisualStyleBackColor = true;
            this.bt_vissza.Click += new System.EventHandler(this.bt_vissza_Click);
            // 
            // felvetel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_vissza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_konyvmufaj);
            this.Controls.Add(this.tb_konyvmegj);
            this.Controls.Add(this.tb_konyvkiado);
            this.Controls.Add(this.tb_konyvszerzo);
            this.Controls.Add(this.tb_konyvcim);
            this.Controls.Add(this.konyv_mufaj);
            this.Controls.Add(this.konyv_megj);
            this.Controls.Add(this.konyv_kiado);
            this.Controls.Add(this.konyv_szerzo);
            this.Controls.Add(this.konyv_cim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "felvetel";
            this.Text = "Könyv felvétel";
            this.Load += new System.EventHandler(this.felvetel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label konyv_cim;
        private System.Windows.Forms.Label konyv_szerzo;
        private System.Windows.Forms.Label konyv_kiado;
        private System.Windows.Forms.Label konyv_megj;
        private System.Windows.Forms.Label konyv_mufaj;
        private System.Windows.Forms.TextBox tb_konyvcim;
        private System.Windows.Forms.TextBox tb_konyvszerzo;
        private System.Windows.Forms.TextBox tb_konyvkiado;
        private System.Windows.Forms.TextBox tb_konyvmegj;
        private System.Windows.Forms.TextBox tb_konyvmufaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_vissza;
    }
}