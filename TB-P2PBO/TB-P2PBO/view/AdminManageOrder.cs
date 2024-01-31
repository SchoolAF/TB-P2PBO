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
    public partial class AdminManageOrder : Form
    {
        private Koneksi koneksi = new Koneksi();
        M_orders m_orders = new M_orders();

        public AdminManageOrder()
        {
            InitializeComponent();
        }

        private void AdminManageOrder_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void Tampil()
        {
            dataTiket.DataSource = koneksi.ShowData("SELECT id, idevent, nama, email, gender, status FROM orders");
            dataTiket.Columns[0].HeaderText = "Order No.";
            dataTiket.Columns[1].HeaderText = "Event ID";
            dataTiket.Columns[2].HeaderText = "Name";
            dataTiket.Columns[3].HeaderText = "Email";
            dataTiket.Columns[4].HeaderText = "Gender";
            dataTiket.Columns[5].HeaderText = "Status";
        }

        private void btn_Confirm_Tiket_Click(object sender, EventArgs e)
        {
            orders orders = new orders();
            orders.ConfirmOrder(tbOrder_ID.Text);
            Tampil();
        }

        private void dataTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOrder_ID.Text = dataTiket.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Cancel_Tiket_Click(object sender, EventArgs e)
        {
            orders orders = new orders();
            orders.CancelOrder(tbOrder_ID.Text);
            Tampil();
        }
    }
}
