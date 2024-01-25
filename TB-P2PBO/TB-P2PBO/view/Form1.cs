using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_P2PBO.view;

namespace TB_P2PBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Jpop_Click(object sender, EventArgs e)
        {
            // Membuat objek form Jpop
            Jpop jpopForm = new Jpop();

            // Menampilkan form Jpop
            jpopForm.Show();
        }

        private void btn_Kpop_Click(object sender, EventArgs e)
        {
            Kpop kpopForm = new Kpop();

            // Menampilkan form Jpop
            kpopForm.Show();
        }

        private void btn_Rnb_Click(object sender, EventArgs e)
        {
            Rnb rnbForm = new Rnb();

            // Menampilkan form Jpop
            rnbForm.Show();
        }

        private void btn_Dub_Click(object sender, EventArgs e)
        {
            // Membuat objek form Dubstep
            Dubstep dubstepForm = new Dubstep();

            // Menampilkan form Dubstep secara modally
            dubstepForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
