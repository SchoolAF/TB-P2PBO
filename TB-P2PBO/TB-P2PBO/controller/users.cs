using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_P2PBO.model;

namespace TB_P2PBO.controller
{
    internal class users
    {
        Koneksi koneksi = new Koneksi();

        public bool InsertUser(M_users users)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                string query = "INSERT INTO users (id, username, password) " +
               "VALUES('" + users.ID + "', '" + users.Username + "', '" + users.Password + "')";

                koneksi.ExecuteQuery(query);

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
