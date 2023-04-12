namespace C_PL.Sub_views
{
    partial class SubFrm_DoiMatKhau
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
            this.pn_doimk = new System.Windows.Forms.Panel();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matkhaumoi = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.pn_doimk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_doimk
            // 
            this.pn_doimk.Controls.Add(this.btn_doimk);
            this.pn_doimk.Controls.Add(this.label3);
            this.pn_doimk.Controls.Add(this.label2);
            this.pn_doimk.Controls.Add(this.txt_matkhaumoi);
            this.pn_doimk.Controls.Add(this.txt_taikhoan);
            this.pn_doimk.Location = new System.Drawing.Point(12, 12);
            this.pn_doimk.Name = "pn_doimk";
            this.pn_doimk.Size = new System.Drawing.Size(572, 215);
            this.pn_doimk.TabIndex = 5;
            // 
            // btn_doimk
            // 
            this.btn_doimk.Location = new System.Drawing.Point(212, 165);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(143, 34);
            this.btn_doimk.TabIndex = 4;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Location = new System.Drawing.Point(127, 120);
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.Size = new System.Drawing.Size(322, 31);
            this.txt_matkhaumoi.TabIndex = 1;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Enabled = false;
            this.txt_taikhoan.Location = new System.Drawing.Point(127, 58);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(322, 31);
            this.txt_taikhoan.TabIndex = 0;
            // 
            // SubFrm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 237);
            this.Controls.Add(this.pn_doimk);
            this.Name = "SubFrm_DoiMatKhau";
            this.Text = "SubFrm_DoiMatKhau";
            this.pn_doimk.ResumeLayout(false);
            this.pn_doimk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_doimk;
        private Button btn_doimk;
        private Label label3;
        private Label label2;
        private TextBox txt_matkhaumoi;
        private TextBox txt_taikhoan;
    }
}