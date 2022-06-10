using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeremGaleri.Arayuz
{
    public partial class AraclarForm : Form
    {
        public AraclarForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        public Urun Urun { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(Urunn)) return;
            if (!ErrorControl(Kategori)) return;
            if (!ErrorControl(Fiyat)) return;
            if (!ErrorControl(Stok)) return;
            if (!ErrorControl(Birim)) return;
            if (!ErrorControl(Detay)) return;

            Urun.Ad = Urunn.Text;
            Urun.Kategori = Kategori.Text;
            Urun.Fiyat = (double)Fiyat.Value;
            Urun.Stok = (double)Stok.Value;
            Urun.Birim = Birim.Text;
            Urun.Detay = Detay.Text;


            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }

            return true;

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            Id.Text = Urun.ID.ToString();
            if (Güncelleme)
            {
                Urunn.Text = Urun.Ad;
                Kategori.Text = Urun.Kategori;
                Fiyat.Value = (decimal)Urun.Fiyat;
                Stok.Value = (decimal)Urun.Stok;
                Birim.Text = Urun.Birim;
                Detay.Text = Urun.Detay;


            }
        }
    }
}
