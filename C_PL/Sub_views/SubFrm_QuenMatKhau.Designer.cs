namespace C_PL.Sub_views
{
    partial class SubFrm_QuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_gui = new System.Windows.Forms.Button();
            this.pn_khoiphuc = new System.Windows.Forms.Panel();
            this.btn_xacthuc = new System.Windows.Forms.Button();
            this.txt_otp = new System.Windows.Forms.TextBox();
            this.pn_khoiphuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập email khôi phục mật khẩu";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(26, 47);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(281, 31);
            this.txt_email.TabIndex = 1;
            // 
            // btn_gui
            // 
            this.btn_gui.Location = new System.Drawing.Point(369, 45);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(167, 34);
            this.btn_gui.TabIndex = 2;
            this.btn_gui.Text = "Gửi mã xác thực";
            this.btn_gui.UseVisualStyleBackColor = true;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // pn_khoiphuc
            // 
            this.pn_khoiphuc.Controls.Add(this.btn_xacthuc);
            this.pn_khoiphuc.Controls.Add(this.txt_otp);
            this.pn_khoiphuc.Controls.Add(this.label1);
            this.pn_khoiphuc.Controls.Add(this.btn_gui);
            this.pn_khoiphuc.Controls.Add(this.txt_email);
            this.pn_khoiphuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_khoiphuc.Location = new System.Drawing.Point(0, 0);
            this.pn_khoiphuc.Name = "pn_khoiphuc";
            this.pn_khoiphuc.Size = new System.Drawing.Size(572, 150);
            this.pn_khoiphuc.TabIndex = 3;
            // 
            // btn_xacthuc
            // 
            this.btn_xacthuc.Location = new System.Drawing.Point(369, 98);
            this.btn_xacthuc.Name = "btn_xacthuc";
            this.btn_xacthuc.Size = new System.Drawing.Size(167, 34);
            this.btn_xacthuc.TabIndex = 5;
            this.btn_xacthuc.Text = "Xác thực tài khoản";
            this.btn_xacthuc.UseVisualStyleBackColor = true;
            this.btn_xacthuc.Click += new System.EventHandler(this.btn_xacthuc_Click);
            // 
            // txt_otp
            // 
            this.txt_otp.Location = new System.Drawing.Point(26, 100);
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.Size = new System.Drawing.Size(281, 31);
            this.txt_otp.TabIndex = 3;
            // 
            // SubFrm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 214);
            this.Controls.Add(this.pn_khoiphuc);
            this.Name = "SubFrm_QuenMatKhau";
            this.Text = "SubFrm_QuenMatKhau";
            this.pn_khoiphuc.ResumeLayout(false);
            this.pn_khoiphuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txt_email;
        private Button btn_gui;
        private Panel pn_khoiphuc;
        private Button btn_xacthuc;
        private TextBox txt_otp;
    }
}