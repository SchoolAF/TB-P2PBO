using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_P2PBO.model;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace TB_P2PBO.controller
{
    internal class ticket
    {
        Koneksi koneksi = new Koneksi();

        public bool InsertTicket(M_tickets ticket)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                string query = "INSERT INTO events (id, artist, title, price, date, location, stock, genre) " +
                               "VALUES('" + ticket.ID + "', '" + ticket.Artist + "', '" + ticket.Title + "'," +
                               "'" + ticket.Price + "', '" + ticket.Date + "', '" + ticket.Location + "'," +
                               "'" + ticket.Stock + "', '" + ticket.Genre + "')";

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

        public bool UpdateTicket(M_tickets ticket, string id_tiket)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                string query = "UPDATE events SET artist='" + ticket.Artist + "'," +
                               "title='" + ticket.Title + "'," +
                               "price='" + ticket.Price + "'," +
                               "date='" + ticket.Date + "'," +
                               "location='" + ticket.Location + "'," +
                               "stock='" + ticket.Stock + "'," +
                               "genre='" + ticket.Genre + "' " +
                               "WHERE id = '" + id_tiket + "'";

                koneksi.ExecuteQuery(query);

                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
        public bool DeleteTicket(string id_tiket)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM events WHERE id='" + id_tiket + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
