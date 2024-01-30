using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_P2PBO.model
{
    internal class M_tickets

    {
        string id, artist, title, price, date, location, stock, genre;

        public M_tickets()
        {

        }

        public M_tickets(string id, string artist, string title, string price, string date, string location, string stock, string genre)
        {
            this.ID = id;
            this.Artist = artist;
            this.Title = title;
            this.Price = price;
            this.Date = date;
            this.Location = location;
            this.Stock = stock;
            this.Genre = genre;
        }

        public string ID { get => id; set => id = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Title { get => title; set => title = value; }
        public string Price { get => price; set => price = value; }
        public string Date { get => date; set => date = value; }
        public string Location { get => location; set => location = value; }
        public string Stock { get => stock; set => stock = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
