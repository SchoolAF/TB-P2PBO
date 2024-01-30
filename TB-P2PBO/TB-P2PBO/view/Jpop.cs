using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_P2PBO.controller;
using TB_P2PBO.model;

namespace TB_P2PBO.view
{
    public partial class Jpop : Form
    {
        private Koneksi koneksi = new Koneksi();
        M_orders m_orders = new M_orders();

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

            orders orders = new orders();
            m_orders.ID = Guid.NewGuid().ToString();
            m_orders.Nama = tb_namaJpop.Text;
            m_orders.Email = tb_emailJpop.Text;


            string jenisKelamin = rb_jpopL.Checked ? "Laki-Laki" : "Perempuan";
            m_orders.Gender = jenisKelamin;

            orders.InsertOrder(m_orders);

            // Jika semua validasi berhasil, tampilkan pesan pembelian berhasil
            string konserTerpilih = cb_jpop.SelectedItem.ToString();

            string pesan = $"Pembelian tiket berhasil!, Check Email\n\n" +
                           $"Konser: {konserTerpilih}\n" +
                           $"Nama: {tb_namaJpop.Text}\n" +
                           $"Email: {tb_emailJpop.Text}\n" +
                           $"Jenis Kelamin: {jenisKelamin}";

            MessageBox.Show(pesan, "Pembelian Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Jpop_Load(object sender, EventArgs e)
        {
            LoadEventDataIntoComboBox();
        }

        private void LoadEventDataIntoComboBox()
        {
            try
            {
                koneksi.OpenConnection();
                string query = "SELECT id, artist, title, price, location, date FROM events WHERE genre='JPOP'";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    cb_jpop.Items.Clear();
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string artist = reader["artist"].ToString();
                        string title = reader["title"].ToString();
                        string price = reader["price"].ToString();
                        string location = reader["location"].ToString();
                        string date = reader["date"].ToString();

                        // Include the ID in the ComboBox items using the Tag property
                        string displayText = $" [{date}] - {artist} - {title} - USD {price} - {location}";
                        cb_jpop.Items.Add(new ComboboxItem(displayText, id));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void cb_jpop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_jpop.SelectedItem is ComboboxItem selectedItem)
            {
                m_orders.IDEvent = selectedItem.Value;
            }
        }
    }
}
