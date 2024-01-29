using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_P2PBO.view
{
    public partial class Kpop : Form
    {
        public Kpop()
        {
            InitializeComponent();
        }

        private void btn_keluarKpop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpanKpop_Click(object sender, EventArgs e)
        {

            // Validasi input
            if (cb_kpop.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih konser terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_namaKpop.Text))
            {
                MessageBox.Show("Masukkan nama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_emailKpop.Text))
            {
                MessageBox.Show("Masukkan email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rb_kpopL.Checked && !rb_kpopP.Checked)
            {
                MessageBox.Show("Pilih jenis kelamin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jika semua validasi berhasil, tampilkan pesan pembelian berhasil
            string jenisKelamin = rb_kpopL.Checked ? "Laki-Laki" : "Perempuan";
            string konserTerpilih = cb_kpop.SelectedItem.ToString();

            string pesan = $"Pembelian tiket berhasil!, Check Email\n\n" +
                           $"Konser: {konserTerpilih}\n" +
                           $"Nama: {tb_namaKpop.Text}\n" +
                           $"Email: {tb_emailKpop.Text}\n" +
                           $"Jenis Kelamin: {jenisKelamin}";

            MessageBox.Show(pesan, "Pembelian Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
