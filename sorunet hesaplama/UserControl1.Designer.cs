namespace sorunet_hesaplama
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.cmbDogru = new System.Windows.Forms.TextBox();
            this.cmbYanlis = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.Location = new System.Drawing.Point(62, 84);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(118, 25);
            this.lblDogru.TabIndex = 0;
            this.lblDogru.Text = "doğru sayı:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYanlis.Location = new System.Drawing.Point(62, 130);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(119, 25);
            this.lblYanlis.TabIndex = 1;
            this.lblYanlis.Text = "yanlış sayı:";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(71, 177);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(109, 25);
            this.lblNet.TabIndex = 2;
            this.lblNet.Text = "net doğru:";
            // 
            // cmbDogru
            // 
            this.cmbDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDogru.Location = new System.Drawing.Point(203, 84);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(155, 31);
            this.cmbDogru.TabIndex = 3;
            // 
            // cmbYanlis
            // 
            this.cmbYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbYanlis.Location = new System.Drawing.Point(203, 139);
            this.cmbYanlis.Name = "cmbYanlis";
            this.cmbYanlis.Size = new System.Drawing.Size(155, 31);
            this.cmbYanlis.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(67, 215);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(306, 53);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "net doğru hesaplama";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbYanlis);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox cmbDogru;
        private System.Windows.Forms.TextBox cmbYanlis;
        private System.Windows.Forms.Button btnHesapla;
    }
}
