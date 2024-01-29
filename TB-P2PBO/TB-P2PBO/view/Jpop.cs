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
    public partial class Jpop : Form
    {
        public Jpop()
        {
            InitializeComponent();
        }

        private void btn_keluarJpop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpanJpop_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (cb_jpop.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih konser terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_namaJpop.Text))
            {
                MessageBox.Show("Masukkan nama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_emailJpop.Text))
            {
                MessageBox.Show("Masukkan email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rb_jpopL.Checked && !rb_jpopP.Checked)
            {
                MessageBox.Show("Pilih jenis kelamin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jika semua validasi berhasil, tampilkan pesan pembelian berhasil
            string jenisKelamin = rb_jpopL.Checked ? "Laki-Laki" : "Perempuan";
            string konserTerpilih = cb_jpop.SelectedItem.ToString();

            string pesan = $"Pembelian tiket berhasil!, Check Email\n\n" +
                           $"Konser: {konserTerpilih}\n" +
                           $"Nama: {tb_namaJpop.Text}\n" +
                           $"Email: {tb_emailJpop.Text}\n" +
                           $"Jenis Kelamin: {jenisKelamin}";

            MessageBox.Show(pesan, "Pembelian Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
