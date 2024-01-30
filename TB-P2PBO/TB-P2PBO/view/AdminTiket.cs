using Mysqlx.Crud;
using System;
using System.Collections;
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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace TB_P2PBO.view
{
    public partial class AdminTiket : Form
    {
        private Koneksi koneksi = new Koneksi();
        M_tickets m_tickets = new M_tickets();

        public void Tampil()
        {
            dataTiket.DataSource = koneksi.ShowData("SELECT * FROM events");
            dataTiket.Columns[0].HeaderText = "ID";
            dataTiket.Columns[1].HeaderText = "Artist";
            dataTiket.Columns[2].HeaderText = "Title";
            dataTiket.Columns[3].HeaderText = "Price in USD";
            dataTiket.Columns[4].HeaderText = "Date";
            dataTiket.Columns[5].HeaderText = "Location";
            dataTiket.Columns[6].HeaderText = "Stock";
            dataTiket.Columns[7].HeaderText = "Genre";
        }

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

        private void AdminTiket_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void dataTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Id_T.Text = dataTiket.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_Artist_T.Text = dataTiket.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_Title_T.Text = dataTiket.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_Price_T.Text = dataTiket.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTime_T.Text = dataTiket.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_Location_T.Text = dataTiket.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_Stock_T.Text = dataTiket.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_Simpan_Tiket_Click(object sender, EventArgs e)
        {
            if (tb_Id_T.Text == "" || tb_Artist_T.Text == "" || tb_Title_T.Text == "" ||
                tb_Price_T.Text == "" || tb_Location_T.Text == "" || tb_Stock_T.Text == "" ||
                cb_Genre_T.SelectedIndex == -1)
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                M_tickets m_tickets = new M_tickets();

                m_tickets.ID = tb_Id_T.Text;
                m_tickets.Artist = tb_Artist_T.Text;
                m_tickets.Title = tb_Title_T.Text;
                m_tickets.Price = tb_Price_T.Text;

                // Use the Value property of the DateTimePicker
                m_tickets.Date = dateTime_T.Value.ToString("yyyy-MM-dd");

                m_tickets.Location = tb_Location_T.Text;
                m_tickets.Stock = tb_Stock_T.Text;
                m_tickets.Genre = cb_Genre_T.Text;

                ticket ticket = new ticket();
                ticket.InsertTicket(m_tickets);

                Tampil();
            }
        }

        private void btn_Ubah_Tiket_Click(object sender, EventArgs e)
        {
            M_tickets m_tickets = new M_tickets();

            m_tickets.ID = tb_Id_T.Text;
            m_tickets.Artist = tb_Artist_T.Text;
            m_tickets.Title = tb_Title_T.Text;
            m_tickets.Price = tb_Price_T.Text;

            // Use the Value property of the DateTimePicker
            m_tickets.Date = dateTime_T.Value.ToString("yyyy-MM-dd");

            m_tickets.Location = tb_Location_T.Text;
            m_tickets.Stock = tb_Stock_T.Text;
            m_tickets.Genre = cb_Genre_T.Text;

            ticket ticket = new ticket();
            ticket.UpdateTicket(m_tickets, tb_Id_T.Text);

            Tampil();
        }

        private void btn_Hapus_Tiket_Click(object sender, EventArgs e)
        {
            M_tickets m_tickets = new M_tickets();

            m_tickets.ID = tb_Id_T.Text;

            ticket ticket = new ticket();
            ticket.DeleteTicket(tb_Id_T.Text);

            Tampil();
        }

        private void btn_Refresh_Tiket_Click(object sender, EventArgs e)
        {
            Tampil();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}
