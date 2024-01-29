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
    public partial class Dubstep : Form
    {
        public Dubstep()
        {
            InitializeComponent();
        }

        private void btn_keluarDbs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_simpanDbs_Click(object sender, EventArgs e)
        {

            // Validasi input
            if (cb_Dbs.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih konser terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_namaDbs.Text))
            {
                MessageBox.Show("Masukkan nama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_emailDbs.Text))
            {
                MessageBox.Show("Masukkan email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rb_dbsL.Checked && !rb_dbsP.Checked)
            {
                MessageBox.Show("Pilih jenis kelamin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jika semua validasi berhasil, tampilkan pesan pembelian berhasil
            string jenisKelamin = rb_dbsL.Checked ? "Laki-Laki" : "Perempuan";
            string konserTerpilih = cb_Dbs.SelectedItem.ToString();

            string pesan = $"Pembelian tiket berhasil!, Check Email\n\n" +
                           $"Konser: {konserTerpilih}\n" +
                           $"Nama: {tb_namaDbs.Text}\n" +
                           $"Email: {tb_emailDbs.Text}\n" +
                           $"Jenis Kelamin: {jenisKelamin}";  

            MessageBox.Show(pesan, "Pembelian Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

