using System;
using System.Windows.Forms;
using TB_P2PBO.controller;
using TB_P2PBO.model;

namespace TB_P2PBO.view
{
    public partial class Register : Form
    {
        private Koneksi koneksi = new Koneksi();
        M_users m_users = new M_users();

        public Register()
        {
            InitializeComponent();
            SetPlaceholder(tb_userReg, "Username");
            SetPlaceholder(tb_passReg, "Password");
        }

        private void SetPlaceholder(TextBox textBoxa, string placeholder)
        {
            if (string.IsNullOrEmpty(textBoxa.Text))
            {
                textBoxa.Text = placeholder;
                textBoxa.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }

        private void tb_userReg_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_userReg, "Username");
        }

        private void tb_passReg_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_passReg, "Password");
        }

        private void tb_userReg_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_userReg, "Username");
        }

        private void tb_passReg_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_passReg, "Password");
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_userReg.Text))
            {
                MessageBox.Show("Masukkan nama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_passReg.Text))
            {
                MessageBox.Show("Masukkan email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_users.ID = Guid.NewGuid().ToString();
            m_users.Username = tb_userReg.Text;
            m_users.Password = tb_passReg.Text;

            users users = new users();
            users.InsertUser(m_users);

            string pesan = $"User ditambahklan!";

            MessageBox.Show(pesan, "Pembelian Tiket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ;

            this.Hide();
            // Membuka Form Register
            Login LoginForm = new Login();
            LoginForm.Show();
        }
    }
}
