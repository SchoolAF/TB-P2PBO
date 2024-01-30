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
    }
}
