namespace TB_P2PBO.view
{
    partial class AdminManageOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageOrder));
            this.gb_TiketKonser = new System.Windows.Forms.GroupBox();
            this.dataTiket = new System.Windows.Forms.DataGridView();
            this.gb_ActionTicket = new System.Windows.Forms.GroupBox();
            this.btn_Cancel_Tiket = new System.Windows.Forms.Button();
            this.btn_Confirm_Tiket = new System.Windows.Forms.Button();
            this.gb_TiketKonser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTiket)).BeginInit();
            this.gb_ActionTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TiketKonser
            // 
            this.gb_TiketKonser.Controls.Add(this.dataTiket);
            this.gb_TiketKonser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TiketKonser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_TiketKonser.Location = new System.Drawing.Point(28, 24);
            this.gb_TiketKonser.Name = "gb_TiketKonser";
            this.gb_TiketKonser.Size = new System.Drawing.Size(708, 193);
            this.gb_TiketKonser.TabIndex = 2;
            this.gb_TiketKonser.TabStop = false;
            this.gb_TiketKonser.Text = "Tiket Konser";
            // 
            // dataTiket
            // 
            this.dataTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTiket.Location = new System.Drawing.Point(19, 19);
            this.dataTiket.Name = "dataTiket";
            this.dataTiket.Size = new System.Drawing.Size(668, 157);
            this.dataTiket.TabIndex = 0;
            // 
            // gb_ActionTicket
            // 
            this.gb_ActionTicket.Controls.Add(this.btn_Cancel_Tiket);
            this.gb_ActionTicket.Controls.Add(this.btn_Confirm_Tiket);
            this.gb_ActionTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ActionTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_ActionTicket.Location = new System.Drawing.Point(269, 237);
            this.gb_ActionTicket.Name = "gb_ActionTicket";
            this.gb_ActionTicket.Size = new System.Drawing.Size(230, 198);
            this.gb_ActionTicket.TabIndex = 4;
            this.gb_ActionTicket.TabStop = false;
            this.gb_ActionTicket.Text = "Tombol Action";
            // 
            // btn_Cancel_Tiket
            // 
            this.btn_Cancel_Tiket.BackColor = System.Drawing.Color.White;
            this.btn_Cancel_Tiket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel_Tiket.Location = new System.Drawing.Point(21, 115);
            this.btn_Cancel_Tiket.Name = "btn_Cancel_Tiket";
            this.btn_Cancel_Tiket.Size = new System.Drawing.Size(188, 23);
            this.btn_Cancel_Tiket.TabIndex = 1;
            this.btn_Cancel_Tiket.Text = "Cancel";
            this.btn_Cancel_Tiket.UseVisualStyleBackColor = false;
            // 
            // btn_Confirm_Tiket
            // 
            this.btn_Confirm_Tiket.BackColor = System.Drawing.Color.White;
            this.btn_Confirm_Tiket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Confirm_Tiket.Location = new System.Drawing.Point(21, 74);
            this.btn_Confirm_Tiket.Name = "btn_Confirm_Tiket";
            this.btn_Confirm_Tiket.Size = new System.Drawing.Size(188, 23);
            this.btn_Confirm_Tiket.TabIndex = 0;
            this.btn_Confirm_Tiket.Text = "Confirm";
            this.btn_Confirm_Tiket.UseVisualStyleBackColor = false;
            // 
            // AdminManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(765, 458);
            this.Controls.Add(this.gb_TiketKonser);
            this.Controls.Add(this.gb_ActionTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminManageOrder";
            this.Text = "rhythmtix-admin";
            this.gb_TiketKonser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTiket)).EndInit();
            this.gb_ActionTicket.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_TiketKonser;
        private System.Windows.Forms.DataGridView dataTiket;
        private System.Windows.Forms.GroupBox gb_ActionTicket;
        private System.Windows.Forms.Button btn_Cancel_Tiket;
        private System.Windows.Forms.Button btn_Confirm_Tiket;
    }
}