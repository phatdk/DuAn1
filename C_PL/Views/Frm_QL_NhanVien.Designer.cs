namespace C_PL.Views
{
    partial class Frm_QL_NhanVien
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
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            dtg_view_nv = new DataGridView();
            panel2 = new Panel();
            groupBox5 = new GroupBox();
            txt_timkiem = new TextBox();
            groupBox4 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btn_clear = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            groupBox2 = new GroupBox();
            cb_trangthai = new ComboBox();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            cb_chucvu = new ComboBox();
            txt_sdt = new TextBox();
            cb_gioitinh = new ComboBox();
            txt_tennv = new TextBox();
            txt_manv = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_nv).BeginInit();
            panel2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1078, 860);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dtg_view_nv);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(2, 79);
            groupBox6.Margin = new Padding(2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(2);
            groupBox6.Size = new Size(721, 779);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách nhân viên";
            // 
            // dtg_view_nv
            // 
            dtg_view_nv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_nv.Dock = DockStyle.Fill;
            dtg_view_nv.Location = new Point(2, 22);
            dtg_view_nv.Margin = new Padding(2);
            dtg_view_nv.Name = "dtg_view_nv";
            dtg_view_nv.RowHeadersWidth = 62;
            dtg_view_nv.RowTemplate.Height = 33;
            dtg_view_nv.Size = new Size(717, 755);
            dtg_view_nv.TabIndex = 0;
            dtg_view_nv.SelectionChanged += dtg_view_nv_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox5);
            panel2.Controls.Add(groupBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(2, 22);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 57);
            panel2.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_timkiem);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(398, 0);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(318, 57);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Dock = DockStyle.Fill;
            txt_timkiem.Location = new Point(2, 22);
            txt_timkiem.Margin = new Padding(2);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(314, 27);
            txt_timkiem.TabIndex = 0;
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(398, 57);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Lọc";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 24);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tất cả";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(202, 24);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(146, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Không hoạt động";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(90, 24);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hoạt động";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(723, 22);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 836);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_clear);
            groupBox3.Controls.Add(btn_xoa);
            groupBox3.Controls.Add(btn_sua);
            groupBox3.Controls.Add(btn_them);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 536);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(353, 300);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(99, 231);
            btn_clear.Margin = new Padding(2);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(200, 50);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(99, 161);
            btn_xoa.Margin = new Padding(2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(200, 50);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(99, 95);
            btn_sua.Margin = new Padding(2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(200, 50);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(99, 30);
            btn_them.Margin = new Padding(2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(200, 50);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_trangthai);
            groupBox2.Controls.Add(txt_matkhau);
            groupBox2.Controls.Add(txt_taikhoan);
            groupBox2.Controls.Add(cb_chucvu);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(cb_gioitinh);
            groupBox2.Controls.Add(txt_tennv);
            groupBox2.Controls.Add(txt_manv);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(353, 498);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Items.AddRange(new object[] { "Hoạt động", "Không Hoạt Động" });
            cb_trangthai.Location = new Point(20, 461);
            cb_trangthai.Margin = new Padding(2);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(312, 28);
            cb_trangthai.TabIndex = 15;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(20, 403);
            txt_matkhau.Margin = new Padding(2);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(312, 27);
            txt_matkhau.TabIndex = 14;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(20, 345);
            txt_taikhoan.Margin = new Padding(2);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(312, 27);
            txt_taikhoan.TabIndex = 13;
            // 
            // cb_chucvu
            // 
            cb_chucvu.FormattingEnabled = true;
            cb_chucvu.Items.AddRange(new object[] { "ADmin", "Nhân Viên Bán Hàng" });
            cb_chucvu.Location = new Point(20, 286);
            cb_chucvu.Margin = new Padding(2);
            cb_chucvu.Name = "cb_chucvu";
            cb_chucvu.Size = new Size(312, 28);
            cb_chucvu.TabIndex = 12;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(20, 228);
            txt_sdt.Margin = new Padding(2);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(312, 27);
            txt_sdt.TabIndex = 11;
            // 
            // cb_gioitinh
            // 
            cb_gioitinh.FormattingEnabled = true;
            cb_gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cb_gioitinh.Location = new Point(20, 168);
            cb_gioitinh.Margin = new Padding(2);
            cb_gioitinh.Name = "cb_gioitinh";
            cb_gioitinh.Size = new Size(312, 28);
            cb_gioitinh.TabIndex = 10;
            // 
            // txt_tennv
            // 
            txt_tennv.Location = new Point(20, 110);
            txt_tennv.Margin = new Padding(2);
            txt_tennv.Name = "txt_tennv";
            txt_tennv.Size = new Size(312, 27);
            txt_tennv.TabIndex = 9;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(20, 51);
            txt_manv.Margin = new Padding(2);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(312, 27);
            txt_manv.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 438);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 7;
            label8.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 381);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 322);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 5;
            label6.Text = "Tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 263);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 206);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 146);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // Frm_QL_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 860);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Frm_QL_NhanVien";
            Text = "Frm_QL_NhanVien";
            Load += Frm_QL_NhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_nv).EndInit();
            panel2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private ComboBox cb_trangthai;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private ComboBox cb_chucvu;
        private TextBox txt_sdt;
        private ComboBox cb_gioitinh;
        private TextBox txt_tennv;
        private TextBox txt_manv;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox5;
        private TextBox txt_timkiem;
        private GroupBox groupBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox groupBox6;
        private DataGridView dtg_view_nv;
        private GroupBox groupBox3;
        private Button btn_clear;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}