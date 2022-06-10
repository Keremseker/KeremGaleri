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
    public partial class AracSatisForm : Form
    {
        public AracSatisForm()
        {
            InitializeComponent();
        }

        public Satis Satis { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Fiyat.Value == 0)
            {
                errorProvider1.SetError(Fiyat, "Lütfen fiyat giriniz!");
                Fiyat.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(Fiyat, "");
            }

            Satis.Tarih = Tarih.Value;
            Satis.Fiyat = (double)Fiyat.Value;
            Satis.UrunID = Guid.Parse( Urun.Text);
            Satis.MusteriID = Guid.Parse( Musteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            Id.Text = Satis.ID.ToString();
            if (Güncelleme)
            {
                Musteri.Text = Satis.MusteriID.ToString();
                Urun.Text = Satis.UrunID.ToString();
                Fiyat.Value = (decimal)Satis.Fiyat;
                Tarih.Value = Satis.Tarih;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Musteri.Text = frm.Musteri.ID.ToString ();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araclar frm = new Araclar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Urun.Text = frm.Urun.ID.ToString();
            }
        }
    }
}
