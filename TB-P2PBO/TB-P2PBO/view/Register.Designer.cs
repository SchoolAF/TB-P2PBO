namespace TB_P2PBO.view
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_passReg = new System.Windows.Forms.TextBox();
            this.tb_userReg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TB_P2PBO.Properties.Resources._20240130_170413;
            this.pictureBox1.Location = new System.Drawing.Point(-26, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(241, 258);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "Register";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_passReg
            // 
            this.tb_passReg.Location = new System.Drawing.Point(89, 192);
            this.tb_passReg.Name = "tb_passReg";
            this.tb_passReg.Size = new System.Drawing.Size(227, 20);
            this.tb_passReg.TabIndex = 8;
            this.tb_passReg.UseSystemPasswordChar = true;
            this.tb_passReg.Enter += new System.EventHandler(this.tb_passReg_Enter);
            // 
            // tb_userReg
            // 
            this.tb_userReg.Location = new System.Drawing.Point(89, 149);
            this.tb_userReg.Name = "tb_userReg";
            this.tb_userReg.Size = new System.Drawing.Size(227, 20);
            this.tb_userReg.TabIndex = 7;
            this.tb_userReg.Enter += new System.EventHandler(this.tb_userReg_Enter);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 354);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_passReg);
            this.Controls.Add(this.tb_userReg);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "rhythmtix";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_passReg;
        private System.Windows.Forms.TextBox tb_userReg;
    }
}