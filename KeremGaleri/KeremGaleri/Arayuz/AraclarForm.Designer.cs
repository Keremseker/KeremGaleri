namespace KeremGaleri.Arayuz
{
    partial class AraclarForm
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
            this.İptal = new System.Windows.Forms.Button();
            this.Tamam = new System.Windows.Forms.Button();
            this.Detay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Urunn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Kategori = new System.Windows.Forms.ComboBox();
            this.Fiyat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Birim = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // İptal
            // 
            this.İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptal.Location = new System.Drawing.Point(262, 280);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(75, 23);
            this.İptal.TabIndex = 8;
            this.İptal.Text = "İptal";
            this.İptal.UseVisualStyleBackColor = true;
            this.İptal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Tamam
            // 
            this.Tamam.Location = new System.Drawing.Point(181, 280);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(75, 23);
            this.Tamam.TabIndex = 7;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Detay
            // 
            this.Detay.Location = new System.Drawing.Point(73, 169);
            this.Detay.Multiline = true;
            this.Detay.Name = "Detay";
            this.Detay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Detay.Size = new System.Drawing.Size(264, 88);
            this.Detay.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Detay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori";
            // 
            // Urunn
            // 
            this.Urunn.Location = new System.Drawing.Point(73, 38);
            this.Urunn.Name = "Urunn";
            this.Urunn.Size = new System.Drawing.Size(264, 20);
            this.Urunn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Urun";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(73, 12);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(264, 20);
            this.Id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // Kategori
            // 
            this.Kategori.FormattingEnabled = true;
            this.Kategori.Items.AddRange(new object[] {
            "Sedan",
            "Pick up ",
            "Sports",
            "Suv",
            "Muscle"});
            this.Kategori.Location = new System.Drawing.Point(73, 64);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(264, 21);
            this.Kategori.TabIndex = 2;
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(73, 90);
            this.Fiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(264, 20);
            this.Fiyat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stok Miktarı";
            // 
            // Stok
            // 
            this.Stok.DecimalPlaces = 2;
            this.Stok.Location = new System.Drawing.Point(73, 116);
            this.Stok.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(264, 20);
            this.Stok.TabIndex = 4;
            this.Stok.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birim";
            // 
            // Birim
            // 
            this.Birim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Birim.FormattingEnabled = true;
            this.Birim.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.Birim.Location = new System.Drawing.Point(73, 142);
            this.Birim.Name = "Birim";
            this.Birim.Size = new System.Drawing.Size(264, 21);
            this.Birim.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AraclarForm
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptal;
            this.ClientSize = new System.Drawing.Size(355, 318);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.Birim);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.Detay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Urunn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AraclarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arabalar";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.TextBox Detay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Urunn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Kategori;
        private System.Windows.Forms.NumericUpDown Fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Stok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Birim;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}