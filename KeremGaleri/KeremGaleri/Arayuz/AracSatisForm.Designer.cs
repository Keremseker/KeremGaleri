namespace KeremGaleri.Arayuz
{
    partial class AracSatisForm
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
            this.components = new System.ComponentModel.Container();
            this.Fiyat = new System.Windows.Forms.NumericUpDown();
            this.btniptal = new System.Windows.Forms.Button();
            this.btntamam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Musteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Urun = new System.Windows.Forms.TextBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MusteriBul = new System.Windows.Forms.Button();
            this.ÜrünBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(60, 90);
            this.Fiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(226, 20);
            this.Fiyat.TabIndex = 3;
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(211, 152);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 6;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(130, 152);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(75, 23);
            this.btntamam.TabIndex = 5;
            this.btntamam.Text = "Tamam";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Araba";
            // 
            // Musteri
            // 
            this.Musteri.Location = new System.Drawing.Point(60, 38);
            this.Musteri.Name = "Musteri";
            this.Musteri.ReadOnly = true;
            this.Musteri.Size = new System.Drawing.Size(226, 20);
            this.Musteri.TabIndex = 1;
            this.Musteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Müşteri";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(60, 12);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(226, 20);
            this.Id.TabIndex = 0;
            this.Id.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // Urun
            // 
            this.Urun.Location = new System.Drawing.Point(60, 64);
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Size = new System.Drawing.Size(226, 20);
            this.Urun.TabIndex = 2;
            this.Urun.TabStop = false;
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(60, 116);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(226, 20);
            this.Tarih.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MusteriBul
            // 
            this.MusteriBul.Location = new System.Drawing.Point(292, 36);
            this.MusteriBul.Name = "MusteriBul";
            this.MusteriBul.Size = new System.Drawing.Size(106, 23);
            this.MusteriBul.TabIndex = 31;
            this.MusteriBul.Text = "Müşteri bul";
            this.MusteriBul.UseVisualStyleBackColor = true;
            this.MusteriBul.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // ÜrünBul
            // 
            this.ÜrünBul.Location = new System.Drawing.Point(292, 62);
            this.ÜrünBul.Name = "ÜrünBul";
            this.ÜrünBul.Size = new System.Drawing.Size(106, 23);
            this.ÜrünBul.TabIndex = 31;
            this.ÜrünBul.Text = "Araba Bul";
            this.ÜrünBul.UseVisualStyleBackColor = true;
            this.ÜrünBul.Click += new System.EventHandler(this.button2_Click);
            // 
            // AracSatisForm
            // 
            this.AcceptButton = this.btntamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(410, 192);
            this.Controls.Add(this.ÜrünBul);
            this.Controls.Add(this.MusteriBul);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Urun);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AracSatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Satışlar Formu";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Fiyat;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Musteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Urun;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ÜrünBul;
        private System.Windows.Forms.Button MusteriBul;
    }
}