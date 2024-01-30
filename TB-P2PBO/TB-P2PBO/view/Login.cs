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

namespace TB_P2PBO.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetPlaceholder(tb_username, "Username");
            SetPlaceholder(tb_password, "Password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Membuat objek form ParentForm
            AdminPass AdminPass = new AdminPass();

            // Menampilkan form ParentForm secara modally
            AdminPass.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            // Inisialisasi teks placeholder pada load form
            SetPlaceholder(tb_username, "Username");
            SetPlaceholder(tb_password, "Password");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Tetapkan teks placeholder jika TextBox kosong
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            // Hapus teks placeholder saat TextBox mendapatkan fokus
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_username, "Username");
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_password, "Password");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Membuka Form Register
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            // Construct the SQL query to check the credentials
            string query = $"SELECT * FROM users WHERE username='{username}' AND password='{password}'";

            // Use the Koneksi class to execute the query and get the result
            Koneksi koneksi = new Koneksi();
            koneksi.OpenConnection();

            DataTable dataTable = koneksi.ShowData(query);

            koneksi.CloseConnection();

            if (dataTable.Rows.Count > 0)
            {
                this.Hide();
                Form1 Home = new Form1();
                Home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
