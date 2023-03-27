namespace C_PL.Sub_views
{
    partial class SubFrm_ThongTinNhanVien
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.GreenYellow;
            label3.Location = new Point(88, 28);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(392, 51);
            label3.TabIndex = 5;
            label3.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 155);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã nhân viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 155);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Chức vụ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 324);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 8;
            label4.Text = "Số điện thoại :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 266);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 9;
            label5.Text = "Giới tính :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 213);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 10;
            label6.Text = "Tên nhân viên :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 213);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 11;
            label7.Text = "Tài khoản :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(342, 266);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 12;
            label8.Text = "Mật khẩu :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(342, 324);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 13;
            label9.Text = "Trạng thái :";
            // 
            // SubFrm_ThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(571, 475);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "SubFrm_ThongTinNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubFrm_ThongTinNhanVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}