using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB_P2PBO.controller;
using TB_P2PBO.model;

namespace TB_P2PBO.view
{
    public partial class AdminManageOrder : Form
    {
        private Koneksi koneksi = new Koneksi();
        M_orders m_orders = new M_orders();

        public AdminManageOrder()
        {
            InitializeComponent();
        }

        private void AdminManageOrder_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void Tampil()
        {
            dataTiket.DataSource = koneksi.ShowData("SELECT id, idevent, nama, email, gender, status FROM orders");
            dataTiket.Columns[0].HeaderText = "Order No.";
            dataTiket.Columns[1].HeaderText = "Event ID";
            dataTiket.Columns[2].HeaderText = "Name";
            dataTiket.Columns[3].HeaderText = "Email";
            dataTiket.Columns[4].HeaderText = "Gender";
            dataTiket.Columns[5].HeaderText = "Status";
        }

        private void btn_Confirm_Tiket_Click(object sender, EventArgs e)
        {
            orders orders = new orders();
            orders.ConfirmOrder(tbOrder_ID.Text);
            Tampil();
        }

        private void dataTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOrder_ID.Text = dataTiket.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_Cancel_Tiket_Click(object sender, EventArgs e)
        {
            orders orders = new orders();
            orders.CancelOrder(tbOrder_ID.Text);
            Tampil();
        }

        private void ExportToExcel(DataGridView dataGridView, string searchData)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                // Export Headers
                for (int j = 1; j <= dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Columns[j - 1].HeaderText != null)
                    {
                        worksheet.Cells[1, j].Value = dataGridView.Columns[j - 1].HeaderText;
                    }
                }
                // Export Data
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    {
                        string cellValue = (dataGridView.Rows[i].Cells[j].Value != null ? dataGridView.Rows[i].Cells[j].Value.ToString() : "");
                        worksheet.Cells[i + 2, j + 1].Value = cellValue;
                    }
                }
                FileInfo excelFile = new FileInfo(searchData);
                excelPackage.SaveAs(excelFile);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Document (*.xlsx)|*.xlsx";
            save.FileName = "Orders.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({count}){extension}"); count++;
                }
                ExportToExcel(dataTiket, filePath);
            }
        }
    }
}