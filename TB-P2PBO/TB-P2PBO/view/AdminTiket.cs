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
    public partial class AdminTiket : Form
    {
        public AdminTiket()
        {
            InitializeComponent();
            SetPlaceholder(tb_Id_T, "ID");
            SetPlaceholder(tb_Artist_T, "Artist");
            SetPlaceholder(tb_Title_T, "Title");
            SetPlaceholder(tb_Price_T, "Price");
            SetPlaceholder(tb_Location_T, "Location");
            SetPlaceholder(tb_Stock_T, "Stock");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Tetapkan teks placeholder jika TextBox kosong
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Black;
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

        private void gb_ActionTicket_Enter(object sender, EventArgs e)
        {

        }

        private void tb_Id_T_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_Id_T, "ID");
        }

        private void tb_Id_T_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_Id_T, "ID");
        }

        private void tb_Artist_T_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_Artist_T, "Artist");
        }

        private void tb_Artist_T_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_Artist_T, "Artist");
        }

        private void tb_Title_T_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_Title_T, "Title");
        }

        private void tb_Title_T_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_Title_T, "Title");
        }

        private void tb_Price_T_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_Price_T, "Price");
        }

        private void tb_Price_T_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_Price_T, "Price");
        }

        private void dateTime_T_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_Location_T_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_Location_T, "Location");
        }

        private void tb_Location_T_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_Location_T, "Location");
        }

        private void tb_Stock_T_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(tb_Stock_T, "Stock");
        }

        private void tb_Stock_T_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(tb_Stock_T, "Stock");
        }
    }
}
