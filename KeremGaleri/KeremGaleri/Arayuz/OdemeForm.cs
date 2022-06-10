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
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Odeme Odeme { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Tutar.Value == 0)
            {
                errorProvider1.SetError(Tutar, "Lütfen tutar giriniz!");
                Tutar.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(Tutar, "");
            }

            if (Tur.SelectedItem == null)
            {
                errorProvider1.SetError(Tur, "Ödeme türü seçin!");
                Tur.Focus();
                return ;
            }
            else
            {
                errorProvider1.SetError(Tur, "");

            }

            if (Aciklama.Text == "")
            {
                errorProvider1.SetError(Aciklama, "Eksik veya hatalı bilgi");
                Aciklama.Focus();
                return ;
            }
            else
            {
                errorProvider1.SetError(Aciklama, "");
            }

            Odeme.MusteriID = Guid.Parse(Musteri.Text);
            Odeme.Tur = Tur.SelectedItem.ToString();
            Odeme.Tutar = (double)Tutar.Value;
            Odeme.Aciklama = Aciklama.Text;
            Odeme.Tarih = Tarih.Value;


            DialogResult = DialogResult.OK;
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            Id.Text = Odeme.ID.ToString();
            if (Güncelleme)
            {
                Musteri.Text = Odeme.MusteriID.ToString();
                Tutar.Value = (decimal)Odeme.Tutar;
                Tarih.Value = Odeme.Tarih;
                Tur.SelectedItem = Odeme.Tur;
                Aciklama.Text = Odeme.Aciklama.ToString();
            }

        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Musteri.Text = frm.Musteri.ID.ToString();
            }
        }
    }
}
