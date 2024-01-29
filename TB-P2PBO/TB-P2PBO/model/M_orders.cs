using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_P2PBO.model
{
    internal class M_orders

    {
        string id, idevent, nama, email, gender;

        public M_orders()
        {

        }

        public M_orders(string id, string idevent, string nama, string email, string gender)
        {
            this.ID = id;
            this.IDEvent = idevent;
            this.Nama = nama;
            this.Email = email;
            this.Gender = gender;
        }

        public string ID { get => id; set => id = value; }
        public string IDEvent { get => idevent; set => idevent = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
