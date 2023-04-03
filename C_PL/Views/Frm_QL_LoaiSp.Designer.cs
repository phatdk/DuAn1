namespace C_PL.Views
{
	partial class Frm_QL_LoaiSp
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
            this.dtg_view_loaisp = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.txt_tenloaisp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_loaisp)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 641);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý loại sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_view_loaisp);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(633, 546);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách loại sản phẩm";
            // 
            // dtg_view_loaisp
            // 
            this.dtg_view_loaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_loaisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_view_loaisp.Location = new System.Drawing.Point(3, 27);
            this.dtg_view_loaisp.Name = "dtg_view_loaisp";
            this.dtg_view_loaisp.RowHeadersWidth = 62;
            this.dtg_view_loaisp.RowTemplate.Height = 33;
            this.dtg_view_loaisp.Size = new System.Drawing.Size(627, 516);
            this.dtg_view_loaisp.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 65);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(19, 28);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(431, 31);
            this.txt_timkiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.cb_trangthai);
            this.groupBox2.Controls.Add(this.txt_tenloaisp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(636, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 611);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cb_trangthai.Location = new System.Drawing.Point(26, 203);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(388, 33);
            this.cb_trangthai.TabIndex = 3;
            // 
            // txt_tenloaisp
            // 
            this.txt_tenloaisp.Location = new System.Drawing.Point(26, 120);
            this.txt_tenloaisp.Name = "txt_tenloaisp";
            this.txt_tenloaisp.Size = new System.Drawing.Size(388, 31);
            this.txt_tenloaisp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại sản phẩm";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_clear);
            this.groupBox5.Controls.Add(this.btn_xoa);
            this.groupBox5.Controls.Add(this.btn_sua);
            this.groupBox5.Controls.Add(this.btn_them);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 300);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thao tác";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(99, 231);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(200, 50);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(99, 161);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(200, 50);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(99, 95);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(200, 50);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(99, 30);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(200, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // Frm_QL_LoaiSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 641);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_QL_LoaiSp";
            this.Text = "Frm_QL_LoaiSp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_loaisp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			groupBox4 = new GroupBox();
			dtg_view_loaisp = new DataGridView();
			groupBox3 = new GroupBox();
			txt_timkiem = new TextBox();
			groupBox2 = new GroupBox();
			tb_mota = new TextBox();
			groupBox5 = new GroupBox();
			btn_clear = new Button();
			btn_xoa = new Button();
			btn_sua = new Button();
			btn_them = new Button();
			tb_tenloaisp = new TextBox();
			label2 = new Label();
			label1 = new Label();
			groupBox1.SuspendLayout();
			groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_view_loaisp).BeginInit();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox5.SuspendLayout();
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
			groupBox1.Size = new Size(863, 513);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Quản lý loại sản phẩm";
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(dtg_view_loaisp);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(2, 74);
			groupBox4.Margin = new Padding(2);
			groupBox4.Name = "groupBox4";
			groupBox4.Padding = new Padding(2);
			groupBox4.Size = new Size(507, 437);
			groupBox4.TabIndex = 2;
			groupBox4.TabStop = false;
			groupBox4.Text = "Danh sách loại sản phẩm";
			// 
			// dtg_view_loaisp
			// 
			dtg_view_loaisp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_view_loaisp.Dock = DockStyle.Fill;
			dtg_view_loaisp.Location = new Point(2, 22);
			dtg_view_loaisp.Margin = new Padding(2);
			dtg_view_loaisp.Name = "dtg_view_loaisp";
			dtg_view_loaisp.RowHeadersWidth = 62;
			dtg_view_loaisp.RowTemplate.Height = 33;
			dtg_view_loaisp.Size = new Size(503, 413);
			dtg_view_loaisp.TabIndex = 0;
			dtg_view_loaisp.CellClick += dtg_view_loaisp_CellClick;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(txt_timkiem);
			groupBox3.Dock = DockStyle.Top;
			groupBox3.Location = new Point(2, 22);
			groupBox3.Margin = new Padding(2);
			groupBox3.Name = "groupBox3";
			groupBox3.Padding = new Padding(2);
			groupBox3.Size = new Size(507, 52);
			groupBox3.TabIndex = 1;
			groupBox3.TabStop = false;
			groupBox3.Text = "Tìm kiếm";
			// 
			// txt_timkiem
			// 
			txt_timkiem.Location = new Point(15, 22);
			txt_timkiem.Margin = new Padding(2);
			txt_timkiem.Name = "txt_timkiem";
			txt_timkiem.Size = new Size(346, 27);
			txt_timkiem.TabIndex = 0;
			txt_timkiem.TextChanged += txt_timkiem_TextChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(tb_mota);
			groupBox2.Controls.Add(groupBox5);
			groupBox2.Controls.Add(tb_tenloaisp);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Dock = DockStyle.Right;
			groupBox2.Location = new Point(509, 22);
			groupBox2.Margin = new Padding(2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(2);
			groupBox2.Size = new Size(352, 489);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin";
			// 
			// tb_mota
			// 
			tb_mota.Location = new Point(21, 175);
			tb_mota.Margin = new Padding(2);
			tb_mota.Name = "tb_mota";
			tb_mota.Size = new Size(311, 27);
			tb_mota.TabIndex = 6;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(btn_clear);
			groupBox5.Controls.Add(btn_xoa);
			groupBox5.Controls.Add(btn_sua);
			groupBox5.Controls.Add(btn_them);
			groupBox5.Dock = DockStyle.Bottom;
			groupBox5.Location = new Point(2, 247);
			groupBox5.Margin = new Padding(2);
			groupBox5.Name = "groupBox5";
			groupBox5.Padding = new Padding(2);
			groupBox5.Size = new Size(348, 240);
			groupBox5.TabIndex = 5;
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
			btn_clear.Text = "Clear";
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
			// tb_tenloaisp
			// 
			tb_tenloaisp.Location = new Point(21, 96);
			tb_tenloaisp.Margin = new Padding(2);
			tb_tenloaisp.Name = "tb_tenloaisp";
			tb_tenloaisp.Size = new Size(311, 27);
			tb_tenloaisp.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 140);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(48, 20);
			label2.TabIndex = 1;
			label2.Text = "Mô tả";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 74);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(129, 20);
			label1.TabIndex = 0;
			label1.Text = "Tên loại sản phẩm";
			// 
			// Frm_QL_LoaiSp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(863, 513);
			Controls.Add(groupBox1);
			Margin = new Padding(2);
			Name = "Frm_QL_LoaiSp";
			Text = "Frm_QL_LoaiSp";
			groupBox1.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtg_view_loaisp).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox5.ResumeLayout(false);
			ResumeLayout(false);
		}


		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox4;
		private DataGridView dtg_view_loaisp;
		private GroupBox groupBox3;
		private TextBox txt_timkiem;
		private GroupBox groupBox2;
		private TextBox tb_tenloaisp;
		private Label label2;
		private Label label1;
		private GroupBox groupBox5;
		private Button btn_clear;
		private Button btn_xoa;
		private Button btn_sua;
		private Button btn_them;
		private TextBox tb_mota;
	}
}