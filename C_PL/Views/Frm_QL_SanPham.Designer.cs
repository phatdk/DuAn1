namespace C_PL.Views
{
    partial class Frm_QL_SanPham
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

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            dtg_view_sanpham = new DataGridView();
            groupBox3 = new GroupBox();
            tb_timkiem = new TextBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            btn_clear = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            tb_mota = new TextBox();
            label2 = new Label();
            pic_anh = new PictureBox();
            cbb_trangthai = new ComboBox();
            tb_giaban = new TextBox();
            cbb_loaisp = new ComboBox();
            tb_tensp = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_sanpham).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_anh).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(875, 702);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sản phẩm";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtg_view_sanpham);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(2, 80);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(414, 620);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sản phẩm";
            // 
            // dtg_view_sanpham
            // 
            dtg_view_sanpham.BackgroundColor = Color.White;
            dtg_view_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_sanpham.Dock = DockStyle.Fill;
            dtg_view_sanpham.Location = new Point(2, 22);
            dtg_view_sanpham.Margin = new Padding(2);
            dtg_view_sanpham.Name = "dtg_view_sanpham";
            dtg_view_sanpham.RowHeadersWidth = 62;
            dtg_view_sanpham.RowTemplate.Height = 33;
            dtg_view_sanpham.Size = new Size(410, 596);
            dtg_view_sanpham.TabIndex = 0;
            dtg_view_sanpham.CellClick += dtg_view_sanpham_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb_timkiem);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(2, 22);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(414, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            tb_timkiem.Location = new Point(16, 24);
            tb_timkiem.Margin = new Padding(2);
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.Size = new Size(343, 27);
            tb_timkiem.TabIndex = 0;
            tb_timkiem.TextChanged += tb_timkiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(tb_mota);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pic_anh);
            groupBox2.Controls.Add(cbb_trangthai);
            groupBox2.Controls.Add(tb_giaban);
            groupBox2.Controls.Add(cbb_loaisp);
            groupBox2.Controls.Add(tb_tensp);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(416, 22);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(457, 678);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_clear);
            groupBox5.Controls.Add(btn_xoa);
            groupBox5.Controls.Add(btn_sua);
            groupBox5.Controls.Add(btn_them);
            groupBox5.Dock = DockStyle.Bottom;
            groupBox5.Location = new Point(2, 450);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(453, 226);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thao tác";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(79, 185);
            btn_clear.Margin = new Padding(2);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(160, 40);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(79, 129);
            btn_xoa.Margin = new Padding(2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(160, 40);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(79, 76);
            btn_sua.Margin = new Padding(2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(160, 40);
            btn_sua.TabIndex = 1;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(79, 24);
            btn_them.Margin = new Padding(2);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(160, 40);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // tb_mota
            // 
            tb_mota.Location = new Point(19, 343);
            tb_mota.Margin = new Padding(2);
            tb_mota.Multiline = true;
            tb_mota.Name = "tb_mota";
            tb_mota.Size = new Size(238, 87);
            tb_mota.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 321);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 15;
            label2.Text = "Mô tả";
            // 
            // pic_anh
            // 
            pic_anh.Image = Properties.Resources.Co_be_mua_dong__7_1536x864__2_;
            pic_anh.Location = new Point(278, 102);
            pic_anh.Margin = new Padding(2);
            pic_anh.Name = "pic_anh";
            pic_anh.Size = new Size(162, 174);
            pic_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_anh.TabIndex = 13;
            pic_anh.TabStop = false;
            pic_anh.Click += pic_anh_Click;
            // 
            // cbb_trangthai
            // 
            cbb_trangthai.FormattingEnabled = true;
            cbb_trangthai.Items.AddRange(new object[] { "1", "2" });
            cbb_trangthai.Location = new Point(19, 279);
            cbb_trangthai.Margin = new Padding(2);
            cbb_trangthai.Name = "cbb_trangthai";
            cbb_trangthai.Size = new Size(238, 28);
            cbb_trangthai.TabIndex = 12;
            // 
            // tb_giaban
            // 
            tb_giaban.Location = new Point(18, 220);
            tb_giaban.Margin = new Padding(2);
            tb_giaban.Name = "tb_giaban";
            tb_giaban.Size = new Size(238, 27);
            tb_giaban.TabIndex = 11;
            tb_giaban.KeyPress += tb_giaban_KeyPress;
            // 
            // cbb_loaisp
            // 
            cbb_loaisp.FormattingEnabled = true;
            cbb_loaisp.Location = new Point(18, 160);
            cbb_loaisp.Margin = new Padding(2);
            cbb_loaisp.Name = "cbb_loaisp";
            cbb_loaisp.Size = new Size(238, 28);
            cbb_loaisp.TabIndex = 10;
            // 
            // tb_tensp
            // 
            tb_tensp.Location = new Point(19, 102);
            tb_tensp.Margin = new Padding(2);
            tb_tensp.Name = "tb_tensp";
            tb_tensp.Size = new Size(238, 27);
            tb_tensp.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 257);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 198);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // Frm_QL_SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 702);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Frm_QL_SanPham";
            Text = "Frm_QL_SanPham";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_sanpham).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_anh).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tb_giaban;
        private ComboBox cbb_loaisp;
        private TextBox tb_tensp;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pic_anh;
        private GroupBox groupBox4;
        private DataGridView dtg_view_sanpham;
        private GroupBox groupBox3;
        private TextBox tb_timkiem;
        private TextBox tb_mota;
        private Label label2;
        private ComboBox cbb_trangthai;
        private Label label5;
        private GroupBox groupBox5;
        private Button btn_clear;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}