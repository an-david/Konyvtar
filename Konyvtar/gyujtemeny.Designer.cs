namespace Konyvtar
{
    partial class gyujtemeny
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_brutto = new System.Windows.Forms.Label();
            this.bt_vissza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(186, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A gyűjtemény bruttó összértékének értéke:";
            // 
            // lb_brutto
            // 
            this.lb_brutto.AutoSize = true;
            this.lb_brutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_brutto.Location = new System.Drawing.Point(332, 142);
            this.lb_brutto.Name = "lb_brutto";
            this.lb_brutto.Size = new System.Drawing.Size(0, 39);
            this.lb_brutto.TabIndex = 1;
            // 
            // bt_vissza
            // 
            this.bt_vissza.Location = new System.Drawing.Point(713, 12);
            this.bt_vissza.Name = "bt_vissza";
            this.bt_vissza.Size = new System.Drawing.Size(75, 23);
            this.bt_vissza.TabIndex = 2;
            this.bt_vissza.Text = "Vissza";
            this.bt_vissza.UseVisualStyleBackColor = true;
            this.bt_vissza.Click += new System.EventHandler(this.bt_vissza_Click);
            // 
            // gyujtemeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_vissza);
            this.Controls.Add(this.lb_brutto);
            this.Controls.Add(this.label1);
            this.Name = "gyujtemeny";
            this.Text = "Könyv gyűjtemény";
            this.Load += new System.EventHandler(this.gyujtemeny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_brutto;
        private System.Windows.Forms.Button bt_vissza;
    }
}