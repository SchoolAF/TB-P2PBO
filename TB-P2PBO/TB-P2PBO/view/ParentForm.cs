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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void orederTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating an instance of AdminTiket form
            AdminTiket adminTiketForm = new AdminTiket();

            // Setting this form as the MDI parent of AdminTiket
            adminTiketForm.MdiParent = this;

            // Displaying AdminTiket as an MDI child form
            adminTiketForm.Show();
        }

        private void orderTiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creating an instance of AdminManageOrder form
            AdminManageOrder adminManageOrderForm = new AdminManageOrder();

            // Setting this form as the MDI parent of AdminManageOrder
            adminManageOrderForm.MdiParent = this;

            // Displaying AdminManageOrder as an MDI child form
            adminManageOrderForm.Show();
        }
    }
}
