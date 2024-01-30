using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_P2PBO.view
{
    public partial class AdminPass : Form
    {
        public AdminPass()
        {
            InitializeComponent();
        }

        private void AdminPass_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPwd.Text == "1")
            {
                this.Close();
                ShowPanel();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ShowPanel()
        {

            // Membuat objek form ParentForm
            ParentForm parentForm = new ParentForm();

            // Menampilkan form ParentForm secara modally
            parentForm.ShowDialog();

        }
    }
}
