namespace KeremGaleri.Arayuz
{
    partial class MusteriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.MaskedTextBox();
            this.Tamam = new System.Windows.Forms.Button();
            this.İptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(92, 26);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(288, 22);
            this.Id.TabIndex = 0;
            this.Id.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(92, 58);
            this.Ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(288, 22);
            this.Ad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(92, 90);
            this.Soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(288, 22);
            this.Soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mail";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(92, 154);
            this.Mail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(288, 22);
            this.Mail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(92, 186);
            this.Adres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Adres.Multiline = true;
            this.Adres.Name = "Adres";
            this.Adres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Adres.Size = new System.Drawing.Size(288, 107);
            this.Adres.TabIndex = 5;
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(92, 123);
            this.Telefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Telefon.Mask = "\\0(599) 000-0000";
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(288, 22);
            this.Telefon.TabIndex = 3;
            // 
            // Tamam
            // 
            this.Tamam.Location = new System.Drawing.Point(173, 315);
            this.Tamam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(100, 28);
            this.Tamam.TabIndex = 6;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // İptal
            // 
            this.İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptal.Location = new System.Drawing.Point(281, 315);
            this.İptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(100, 28);
            this.İptal.TabIndex = 7;
            this.İptal.Text = "İptal";
            this.İptal.UseVisualStyleBackColor = true;
            this.İptal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMusteri
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptal;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.MaskedTextBox Telefon;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}