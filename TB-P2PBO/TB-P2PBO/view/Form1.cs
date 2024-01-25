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
    }
}
