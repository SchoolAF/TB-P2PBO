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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            SetPlaceholder(tb_userReg, "Username");
            SetPlaceholder(tb_passReg, "Password");

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

        private void btn_Login_Click(object sender, EventArgs e)
        {
           
            // Membuka kembali Form Login
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void tb_userReg_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_userReg, "Username");
        }

        private void tb_passReg_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_passReg, "Password");
        }
    }
}
