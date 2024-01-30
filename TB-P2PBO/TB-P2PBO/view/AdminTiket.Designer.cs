namespace TB_P2PBO.view
{
    partial class AdminTiket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTiket));
            this.gb_TiketKonser = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTiket = new System.Windows.Forms.DataGridView();
            this.gb_TambahTiket = new System.Windows.Forms.GroupBox();
            this.cb_Genre_T = new System.Windows.Forms.ComboBox();
            this.dateTime_T = new System.Windows.Forms.DateTimePicker();
            this.tb_Stock_T = new System.Windows.Forms.TextBox();
            this.tb_Location_T = new System.Windows.Forms.TextBox();
            this.tb_Price_T = new System.Windows.Forms.TextBox();
            this.tb_Title_T = new System.Windows.Forms.TextBox();
            this.tb_Artist_T = new System.Windows.Forms.TextBox();
            this.tb_Id_T = new System.Windows.Forms.TextBox();
            this.gb_ActionTicket = new System.Windows.Forms.GroupBox();
            this.btn_Hapus_Tiket = new System.Windows.Forms.Button();
            this.btn_Ubah_Tiket = new System.Windows.Forms.Button();
            this.btn_Simpan_Tiket = new System.Windows.Forms.Button();
            this.btn_Refresh_Tiket = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_TiketKonser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTiket)).BeginInit();
            this.gb_TambahTiket.SuspendLayout();
            this.gb_ActionTicket.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TiketKonser
            // 
            this.gb_TiketKonser.Controls.Add(this.label1);
            this.gb_TiketKonser.Controls.Add(this.dataTiket);
            this.gb_TiketKonser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TiketKonser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_TiketKonser.Location = new System.Drawing.Point(27, 28);
            this.gb_TiketKonser.Name = "gb_TiketKonser";
            this.gb_TiketKonser.Size = new System.Drawing.Size(708, 193);
            this.gb_TiketKonser.TabIndex = 0;
            this.gb_TiketKonser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiket Konser";
            // 
            // dataTiket
            // 
            this.dataTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTiket.Location = new System.Drawing.Point(19, 19);
            this.dataTiket.Name = "dataTiket";
            this.dataTiket.Size = new System.Drawing.Size(668, 157);
            this.dataTiket.TabIndex = 0;
            this.dataTiket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTiket_CellClick);
            // 
            // gb_TambahTiket
            // 
            this.gb_TambahTiket.Controls.Add(this.cb_Genre_T);
            this.gb_TambahTiket.Controls.Add(this.dateTime_T);
            this.gb_TambahTiket.Controls.Add(this.tb_Stock_T);
            this.gb_TambahTiket.Controls.Add(this.tb_Location_T);
            this.gb_TambahTiket.Controls.Add(this.tb_Price_T);
            this.gb_TambahTiket.Controls.Add(this.tb_Title_T);
            this.gb_TambahTiket.Controls.Add(this.tb_Artist_T);
            this.gb_TambahTiket.Controls.Add(this.tb_Id_T);
            this.gb_TambahTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TambahTiket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_TambahTiket.Location = new System.Drawing.Point(27, 241);
            this.gb_TambahTiket.Name = "gb_TambahTiket";
            this.gb_TambahTiket.Size = new System.Drawing.Size(472, 198);
            this.gb_TambahTiket.TabIndex = 1;
            this.gb_TambahTiket.TabStop = false;
            this.gb_TambahTiket.Text = "Tambah Tiket";
            // 
            // cb_Genre_T
            // 
            this.cb_Genre_T.FormattingEnabled = true;
            this.cb_Genre_T.Items.AddRange(new object[] {
            "JPOP",
            "KPOP",
            "RNB",
            "Dubstep"});
            this.cb_Genre_T.Location = new System.Drawing.Point(244, 160);
            this.cb_Genre_T.Name = "cb_Genre_T";
            this.cb_Genre_T.Size = new System.Drawing.Size(197, 21);
            this.cb_Genre_T.TabIndex = 9;
            // 
            // dateTime_T
            // 
            this.dateTime_T.Location = new System.Drawing.Point(244, 38);
            this.dateTime_T.Name = "dateTime_T";
            this.dateTime_T.Size = new System.Drawing.Size(197, 20);
            this.dateTime_T.TabIndex = 8;
            this.dateTime_T.ValueChanged += new System.EventHandler(this.dateTime_T_ValueChanged);
            // 
            // tb_Stock_T
            // 
            this.tb_Stock_T.Location = new System.Drawing.Point(244, 122);
            this.tb_Stock_T.Name = "tb_Stock_T";
            this.tb_Stock_T.Size = new System.Drawing.Size(197, 20);
            this.tb_Stock_T.TabIndex = 6;
            this.tb_Stock_T.Enter += new System.EventHandler(this.tb_Stock_T_Enter);
            this.tb_Stock_T.Leave += new System.EventHandler(this.tb_Stock_T_Leave);
            // 
            // tb_Location_T
            // 
            this.tb_Location_T.Location = new System.Drawing.Point(244, 79);
            this.tb_Location_T.Name = "tb_Location_T";
            this.tb_Location_T.Size = new System.Drawing.Size(197, 20);
            this.tb_Location_T.TabIndex = 5;
            this.tb_Location_T.Enter += new System.EventHandler(this.tb_Location_T_Enter);
            this.tb_Location_T.Leave += new System.EventHandler(this.tb_Location_T_Leave);
            // 
            // tb_Price_T
            // 
            this.tb_Price_T.Location = new System.Drawing.Point(41, 161);
            this.tb_Price_T.Name = "tb_Price_T";
            this.tb_Price_T.Size = new System.Drawing.Size(197, 20);
            this.tb_Price_T.TabIndex = 3;
            this.tb_Price_T.Enter += new System.EventHandler(this.tb_Price_T_Enter);
            this.tb_Price_T.Leave += new System.EventHandler(this.tb_Price_T_Leave);
            // 
            // tb_Title_T
            // 
            this.tb_Title_T.Location = new System.Drawing.Point(41, 122);
            this.tb_Title_T.Name = "tb_Title_T";
            this.tb_Title_T.Size = new System.Drawing.Size(197, 20);
            this.tb_Title_T.TabIndex = 2;
            this.tb_Title_T.Enter += new System.EventHandler(this.tb_Title_T_Enter);
            this.tb_Title_T.Leave += new System.EventHandler(this.tb_Title_T_Leave);
            // 
            // tb_Artist_T
            // 
            this.tb_Artist_T.Location = new System.Drawing.Point(41, 79);
            this.tb_Artist_T.Name = "tb_Artist_T";
            this.tb_Artist_T.Size = new System.Drawing.Size(197, 20);
            this.tb_Artist_T.TabIndex = 1;
            this.tb_Artist_T.Enter += new System.EventHandler(this.tb_Artist_T_Enter);
            this.tb_Artist_T.Leave += new System.EventHandler(this.tb_Artist_T_Leave);
            // 
            // tb_Id_T
            // 
            this.tb_Id_T.Location = new System.Drawing.Point(41, 38);
            this.tb_Id_T.Name = "tb_Id_T";
            this.tb_Id_T.Size = new System.Drawing.Size(197, 20);
            this.tb_Id_T.TabIndex = 0;
            this.tb_Id_T.Enter += new System.EventHandler(this.tb_Id_T_Enter);
            this.tb_Id_T.Leave += new System.EventHandler(this.tb_Id_T_Leave);
            // 
            // gb_ActionTicket
            // 
            this.gb_ActionTicket.Controls.Add(this.btn_Hapus_Tiket);
            this.gb_ActionTicket.Controls.Add(this.btn_Ubah_Tiket);
            this.gb_ActionTicket.Controls.Add(this.btn_Simpan_Tiket);
            this.gb_ActionTicket.Controls.Add(this.btn_Refresh_Tiket);
            this.gb_ActionTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ActionTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_ActionTicket.Location = new System.Drawing.Point(505, 241);
            this.gb_ActionTicket.Name = "gb_ActionTicket";
            this.gb_ActionTicket.Size = new System.Drawing.Size(230, 198);
            this.gb_ActionTicket.TabIndex = 1;
            this.gb_ActionTicket.TabStop = false;
            this.gb_ActionTicket.Text = "Tombol Action";
            this.gb_ActionTicket.Enter += new System.EventHandler(this.gb_ActionTicket_Enter);
            // 
            // btn_Hapus_Tiket
            // 
            this.btn_Hapus_Tiket.BackColor = System.Drawing.Color.White;
            this.btn_Hapus_Tiket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Hapus_Tiket.Location = new System.Drawing.Point(20, 158);
            this.btn_Hapus_Tiket.Name = "btn_Hapus_Tiket";
            this.btn_Hapus_Tiket.Size = new System.Drawing.Size(188, 23);
            this.btn_Hapus_Tiket.TabIndex = 3;
            this.btn_Hapus_Tiket.Text = "Hapus";
            this.btn_Hapus_Tiket.UseVisualStyleBackColor = false;
            this.btn_Hapus_Tiket.Click += new System.EventHandler(this.btn_Hapus_Tiket_Click);
            // 
            // btn_Ubah_Tiket
            // 
            this.btn_Ubah_Tiket.BackColor = System.Drawing.Color.White;
            this.btn_Ubah_Tiket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ubah_Tiket.Location = new System.Drawing.Point(21, 120);
            this.btn_Ubah_Tiket.Name = "btn_Ubah_Tiket";
            this.btn_Ubah_Tiket.Size = new System.Drawing.Size(188, 23);
            this.btn_Ubah_Tiket.TabIndex = 2;
            this.btn_Ubah_Tiket.Text = "Ubah";
            this.btn_Ubah_Tiket.UseVisualStyleBackColor = false;
            this.btn_Ubah_Tiket.Click += new System.EventHandler(this.btn_Ubah_Tiket_Click);
            // 
            // btn_Simpan_Tiket
            // 
            this.btn_Simpan_Tiket.BackColor = System.Drawing.Color.White;
            this.btn_Simpan_Tiket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Simpan_Tiket.Location = new System.Drawing.Point(21, 79);
            this.btn_Simpan_Tiket.Name = "btn_Simpan_Tiket";
            this.btn_Simpan_Tiket.Size = new System.Drawing.Size(188, 23);
            this.btn_Simpan_Tiket.TabIndex = 1;
            this.btn_Simpan_Tiket.Text = "Simpan";
            this.btn_Simpan_Tiket.UseVisualStyleBackColor = false;
            this.btn_Simpan_Tiket.Click += new System.EventHandler(this.btn_Simpan_Tiket_Click);
            // 
            // btn_Refresh_Tiket
            // 
            this.btn_Refresh_Tiket.BackColor = System.Drawing.Color.White;
            this.btn_Refresh_Tiket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Refresh_Tiket.Location = new System.Drawing.Point(21, 38);
            this.btn_Refresh_Tiket.Name = "btn_Refresh_Tiket";
            this.btn_Refresh_Tiket.Size = new System.Drawing.Size(188, 23);
            this.btn_Refresh_Tiket.TabIndex = 0;
            this.btn_Refresh_Tiket.Text = "Refresh";
            this.btn_Refresh_Tiket.UseVisualStyleBackColor = false;
            this.btn_Refresh_Tiket.Click += new System.EventHandler(this.btn_Refresh_Tiket_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // AdminTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(765, 458);
            this.Controls.Add(this.gb_ActionTicket);
            this.Controls.Add(this.gb_TambahTiket);
            this.Controls.Add(this.gb_TiketKonser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminTiket";
            this.Text = "rhythmtix-admin";
            this.Load += new System.EventHandler(this.AdminTiket_Load);
            this.gb_TiketKonser.ResumeLayout(false);
            this.gb_TiketKonser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTiket)).EndInit();
            this.gb_TambahTiket.ResumeLayout(false);
            this.gb_TambahTiket.PerformLayout();
            this.gb_ActionTicket.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TiketKonser;
        private System.Windows.Forms.GroupBox gb_TambahTiket;
        private System.Windows.Forms.TextBox tb_Id_T;
        private System.Windows.Forms.TextBox tb_Stock_T;
        private System.Windows.Forms.TextBox tb_Location_T;
        private System.Windows.Forms.TextBox tb_Price_T;
        private System.Windows.Forms.TextBox tb_Title_T;
        private System.Windows.Forms.TextBox tb_Artist_T;
        private System.Windows.Forms.GroupBox gb_ActionTicket;
        private System.Windows.Forms.Button btn_Hapus_Tiket;
        private System.Windows.Forms.Button btn_Ubah_Tiket;
        private System.Windows.Forms.Button btn_Simpan_Tiket;
        private System.Windows.Forms.Button btn_Refresh_Tiket;
        private System.Windows.Forms.DataGridView dataTiket;
        private System.Windows.Forms.DateTimePicker dateTime_T;
        private System.Windows.Forms.ComboBox cb_Genre_T;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}