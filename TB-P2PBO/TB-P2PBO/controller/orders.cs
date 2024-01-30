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
    }
}
