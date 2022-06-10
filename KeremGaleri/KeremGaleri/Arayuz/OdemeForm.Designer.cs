namespace KeremGaleri.Arayuz
{
    partial class OdemeForm
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
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.Tutar = new System.Windows.Forms.NumericUpDown();
            this.İptal = new System.Windows.Forms.Button();
            this.Tamam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Musteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Aciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Müsterisec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(84, 62);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(226, 20);
            this.Tarih.TabIndex = 2;
            // 
            // Tutar
            // 
            this.Tutar.Location = new System.Drawing.Point(84, 88);
            this.Tutar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(226, 20);
            this.Tutar.TabIndex = 3;
            // 
            // İptal
            // 
            this.İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptal.Location = new System.Drawing.Point(235, 243);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(75, 23);
            this.İptal.TabIndex = 7;
            this.İptal.Text = "İptal";
            this.İptal.UseVisualStyleBackColor = true;
            this.İptal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Tamam
            // 
            this.Tamam.Location = new System.Drawing.Point(154, 243);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(75, 23);
            this.Tamam.TabIndex = 6;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tutar";
            // 
            // Musteri
            // 
            this.Musteri.Location = new System.Drawing.Point(84, 36);
            this.Musteri.Name = "Musteri";
            this.Musteri.ReadOnly = true;
            this.Musteri.Size = new System.Drawing.Size(226, 20);
            this.Musteri.TabIndex = 1;
            this.Musteri.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Müşteri";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(84, 10);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(226, 20);
            this.Id.TabIndex = 0;
            this.Id.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(84, 144);
            this.Aciklama.Multiline = true;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Aciklama.Size = new System.Drawing.Size(226, 88);
            this.Aciklama.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Açıklama";
            // 
            // Tur
            // 
            this.Tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tur.FormattingEnabled = true;
            this.Tur.Items.AddRange(new object[] {
            "Nakit",
            "Kredi",
            "Kart",
            "Taksit"});
            this.Tur.Location = new System.Drawing.Point(84, 114);
            this.Tur.Name = "Tur";
            this.Tur.Size = new System.Drawing.Size(226, 21);
            this.Tur.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ödeme Türü";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Müsterisec
            // 
            this.Müsterisec.Location = new System.Drawing.Point(316, 34);
            this.Müsterisec.Name = "Müsterisec";
            this.Müsterisec.Size = new System.Drawing.Size(94, 23);
            this.Müsterisec.TabIndex = 47;
            this.Müsterisec.Text = "Müşteri Seç";
            this.Müsterisec.UseVisualStyleBackColor = true;
            this.Müsterisec.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
            // 
            // OdemeForm
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptal;
            this.ClientSize = new System.Drawing.Size(424, 283);
            this.Controls.Add(this.Müsterisec);
            this.Controls.Add(this.Tur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Tutar);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Musteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme Formu";
            this.Load += new System.EventHandler(this.FrmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.NumericUpDown Tutar;
        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Musteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Aciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Tur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Müsterisec;
    }
}