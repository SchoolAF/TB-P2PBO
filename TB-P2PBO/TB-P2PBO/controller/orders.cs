using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_P2PBO.model;

namespace TB_P2PBO.controller
{
    internal class orders
    {
        Koneksi koneksi = new Koneksi();

        public bool InsertOrder(M_orders orders)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO orders (id, idevent, nama, email, gender) VALUES('" + orders.ID + "', '" + orders.IDEvent + "', '" + orders.Nama + "','" + orders.Email + "','" + orders.Gender + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool ConfirmOrder(string order_id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                string query = "UPDATE orders SET status='Confirmed' WHERE id = '" + order_id + "'";

                koneksi.ExecuteQuery(query);

                status = true;
                MessageBox.Show("Transkaksi Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool CancelOrder(string order_id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                string query = "UPDATE orders SET status='Canceled' WHERE id = '" + order_id + "'";

                koneksi.ExecuteQuery(query);

                status = true;
                MessageBox.Show("Transkaksi Berhasil dibatalkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
