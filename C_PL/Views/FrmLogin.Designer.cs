namespace C_PL.Views
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            txt_TaiKhoan = new TextBox();
            txt_MatKhau = new TextBox();
            label3 = new Label();
            btn_DangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 120);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 182);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(336, 142);
            txt_TaiKhoan.Margin = new Padding(2);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(258, 27);
            txt_TaiKhoan.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(336, 204);
            txt_MatKhau.Margin = new Padding(2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(258, 27);
            txt_MatKhau.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.GreenYellow;
            label3.Location = new Point(324, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(224, 51);
            label3.TabIndex = 4;
            label3.Text = "Đăng nhập";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DangNhap.Location = new Point(373, 261);
            btn_DangNhap.Margin = new Padding(2);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(159, 39);
            btn_DangNhap.TabIndex = 5;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_log_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(900, 390);
            Controls.Add(btn_DangNhap);
            Controls.Add(label3);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_TaiKhoan;
        private TextBox txt_MatKhau;
        private Label label3;
        private Button btn_DangNhap;
    }
}