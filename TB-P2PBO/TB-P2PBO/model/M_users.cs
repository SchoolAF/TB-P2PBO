using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_P2PBO.model
{
    internal class M_users

    {
        string id, username, password;

        public M_users()
        {

        }

        public M_users(string id, string username, string password)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
        }

        public string ID { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
