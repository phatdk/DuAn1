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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtg_view_sanpham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_anh = new System.Windows.Forms.PictureBox();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.cbb_loaisp = new System.Windows.Forms.ComboBox();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_sanpham)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1094, 878);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_view_sanpham);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(2, 98);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(519, 778);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm";
            // 
            // dtg_view_sanpham
            // 
            this.dtg_view_sanpham.BackgroundColor = System.Drawing.Color.White;
            this.dtg_view_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_view_sanpham.Location = new System.Drawing.Point(2, 26);
            this.dtg_view_sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_view_sanpham.Name = "dtg_view_sanpham";
            this.dtg_view_sanpham.RowHeadersWidth = 62;
            this.dtg_view_sanpham.RowTemplate.Height = 33;
            this.dtg_view_sanpham.Size = new System.Drawing.Size(515, 750);
            this.dtg_view_sanpham.TabIndex = 0;
            this.dtg_view_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_sanpham_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_timkiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(519, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(20, 30);
            this.tb_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(428, 31);
            this.tb_timkiem.TabIndex = 0;
            this.tb_timkiem.TextChanged += new System.EventHandler(this.tb_timkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.tb_mota);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pic_anh);
            this.groupBox2.Controls.Add(this.cbb_trangthai);
            this.groupBox2.Controls.Add(this.tb_giaban);
            this.groupBox2.Controls.Add(this.cbb_loaisp);
            this.groupBox2.Controls.Add(this.tb_tensp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(521, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(571, 850);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_clear);
            this.groupBox5.Controls.Add(this.btn_xoa);
            this.groupBox5.Controls.Add(this.btn_sua);
            this.groupBox5.Controls.Add(this.btn_them);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(2, 566);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(567, 282);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thao tác";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(99, 231);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(200, 50);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(99, 161);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(200, 50);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(99, 95);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(200, 50);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(99, 30);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(200, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_mota
            // 
            this.tb_mota.Location = new System.Drawing.Point(24, 429);
            this.tb_mota.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(296, 108);
            this.tb_mota.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mô tả";
            // 
            // pic_anh
            // 
            this.pic_anh.Image = global::C_PL.Properties.Resources.Co_be_mua_dong__7_1536x864__2_;
            this.pic_anh.Location = new System.Drawing.Point(348, 128);
            this.pic_anh.Margin = new System.Windows.Forms.Padding(2);
            this.pic_anh.Name = "pic_anh";
            this.pic_anh.Size = new System.Drawing.Size(202, 218);
            this.pic_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anh.TabIndex = 13;
            this.pic_anh.TabStop = false;
            this.pic_anh.Click += new System.EventHandler(this.pic_anh_Click);
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_trangthai.Location = new System.Drawing.Point(24, 349);
            this.cbb_trangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(296, 33);
            this.cbb_trangthai.TabIndex = 12;
            // 
            // tb_giaban
            // 
            this.tb_giaban.Location = new System.Drawing.Point(22, 275);
            this.tb_giaban.Margin = new System.Windows.Forms.Padding(2);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(296, 31);
            this.tb_giaban.TabIndex = 11;
            // 
            // cbb_loaisp
            // 
            this.cbb_loaisp.FormattingEnabled = true;
            this.cbb_loaisp.Location = new System.Drawing.Point(22, 200);
            this.cbb_loaisp.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_loaisp.Name = "cbb_loaisp";
            this.cbb_loaisp.Size = new System.Drawing.Size(296, 33);
            this.cbb_loaisp.TabIndex = 10;
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(24, 128);
            this.tb_tensp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(296, 31);
            this.tb_tensp.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // Frm_QL_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 878);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_QL_SanPham";
            this.Text = "Frm_QL_SanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_sanpham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).EndInit();
            this.ResumeLayout(false);

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