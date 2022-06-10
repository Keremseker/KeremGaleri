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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Musteri Musteri { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(Ad)) return;
            if (!ErrorControl(Soyad)) return;
            if (!ErrorControl(Telefon)) return;
            if (!ErrorControl(Mail)) return;
            if (!ErrorControl(Adres)) return;

            Musteri.Ad = Ad.Text;
            Musteri.Soyad = Soyad.Text;
            Musteri.Telefon = Telefon.Text;
            Musteri.Mail = Mail.Text;
            Musteri.Adres = Adres.Text;

            DialogResult =DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            Id.Text = Musteri.ID.ToString();
            if (Güncelleme)
            {
                Ad.Text = Musteri.Ad;
                Soyad.Text = Musteri.Soyad;
                Telefon.Text = Musteri.Telefon;
                Mail.Text = Musteri.Mail;
                Adres.Text = Musteri.Adres;

            }


        }
    }
}
