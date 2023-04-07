namespace C_PL.Views
{
    partial class Frm_QL_KhuyenMai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtg_view_khuyenmai = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_hethan = new System.Windows.Forms.RadioButton();
            this.rd_dangdung = new System.Windows.Forms.RadioButton();
            this.rd_chuadung = new System.Windows.Forms.RadioButton();
            this.rd_tatca = new System.Windows.Forms.RadioButton();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_sudung = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.dtp_ngaykt = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.txt_sotien = new System.Windows.Forms.TextBox();
            this.txt_phantram = new System.Windows.Forms.TextBox();
            this.txt_dkgiam = new System.Windows.Forms.TextBox();
            this.txt_tenkm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_khuyenmai)).BeginInit();
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1340, 920);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý khuyến mãi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_view_khuyenmai);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(2, 138);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(896, 780);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khuyến mãi";
            // 
            // dtg_view_khuyenmai
            // 
            this.dtg_view_khuyenmai.BackgroundColor = System.Drawing.Color.White;
            this.dtg_view_khuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_khuyenmai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_view_khuyenmai.Location = new System.Drawing.Point(2, 26);
            this.dtg_view_khuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_view_khuyenmai.Name = "dtg_view_khuyenmai";
            this.dtg_view_khuyenmai.RowHeadersWidth = 62;
            this.dtg_view_khuyenmai.RowTemplate.Height = 33;
            this.dtg_view_khuyenmai.Size = new System.Drawing.Size(892, 752);
            this.dtg_view_khuyenmai.TabIndex = 0;
            this.dtg_view_khuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_khuyenmai_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_hethan);
            this.groupBox3.Controls.Add(this.rd_dangdung);
            this.groupBox3.Controls.Add(this.rd_chuadung);
            this.groupBox3.Controls.Add(this.rd_tatca);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(896, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // rd_hethan
            // 
            this.rd_hethan.AutoSize = true;
            this.rd_hethan.Location = new System.Drawing.Point(502, 30);
            this.rd_hethan.Margin = new System.Windows.Forms.Padding(2);
            this.rd_hethan.Name = "rd_hethan";
            this.rd_hethan.Size = new System.Drawing.Size(99, 29);
            this.rd_hethan.TabIndex = 4;
            this.rd_hethan.Text = "Hết hạn";
            this.rd_hethan.UseVisualStyleBackColor = true;
            this.rd_hethan.CheckedChanged += new System.EventHandler(this.rd_hethan_CheckedChanged);
            // 
            // rd_dangdung
            // 
            this.rd_dangdung.AutoSize = true;
            this.rd_dangdung.Location = new System.Drawing.Point(299, 30);
            this.rd_dangdung.Margin = new System.Windows.Forms.Padding(2);
            this.rd_dangdung.Name = "rd_dangdung";
            this.rd_dangdung.Size = new System.Drawing.Size(197, 29);
            this.rd_dangdung.TabIndex = 3;
            this.rd_dangdung.Text = "Đang được sử dụng";
            this.rd_dangdung.UseVisualStyleBackColor = true;
            this.rd_dangdung.CheckedChanged += new System.EventHandler(this.rd_dangdung_CheckedChanged);
            // 
            // rd_chuadung
            // 
            this.rd_chuadung.AutoSize = true;
            this.rd_chuadung.Location = new System.Drawing.Point(98, 30);
            this.rd_chuadung.Margin = new System.Windows.Forms.Padding(2);
            this.rd_chuadung.Name = "rd_chuadung";
            this.rd_chuadung.Size = new System.Drawing.Size(195, 29);
            this.rd_chuadung.TabIndex = 2;
            this.rd_chuadung.Text = "Chưa được sử dụng";
            this.rd_chuadung.UseVisualStyleBackColor = true;
            this.rd_chuadung.CheckedChanged += new System.EventHandler(this.rd_chuadung_CheckedChanged);
            // 
            // rd_tatca
            // 
            this.rd_tatca.AutoSize = true;
            this.rd_tatca.Checked = true;
            this.rd_tatca.Location = new System.Drawing.Point(9, 30);
            this.rd_tatca.Margin = new System.Windows.Forms.Padding(2);
            this.rd_tatca.Name = "rd_tatca";
            this.rd_tatca.Size = new System.Drawing.Size(83, 29);
            this.rd_tatca.TabIndex = 1;
            this.rd_tatca.TabStop = true;
            this.rd_tatca.Text = "Tất cả";
            this.rd_tatca.UseVisualStyleBackColor = true;
            this.rd_tatca.CheckedChanged += new System.EventHandler(this.rd_tatca_CheckedChanged);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(30, 70);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.PlaceholderText = "Tìm kiếm tên khuyến mãi";
            this.txt_timkiem.Size = new System.Drawing.Size(358, 31);
            this.txt_timkiem.TabIndex = 0;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_sudung);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.txt_mota);
            this.groupBox2.Controls.Add(this.dtp_ngaykt);
            this.groupBox2.Controls.Add(this.dtp_ngaybd);
            this.groupBox2.Controls.Add(this.txt_sotien);
            this.groupBox2.Controls.Add(this.txt_phantram);
            this.groupBox2.Controls.Add(this.txt_dkgiam);
            this.groupBox2.Controls.Add(this.txt_tenkm);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(898, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(440, 892);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // cb_sudung
            // 
            this.cb_sudung.AutoSize = true;
            this.cb_sudung.Location = new System.Drawing.Point(21, 534);
            this.cb_sudung.Name = "cb_sudung";
            this.cb_sudung.Size = new System.Drawing.Size(106, 29);
            this.cb_sudung.TabIndex = 17;
            this.cb_sudung.Text = "Sử dụng";
            this.cb_sudung.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trạng thái";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_clear);
            this.groupBox5.Controls.Add(this.btn_xoa);
            this.groupBox5.Controls.Add(this.btn_sua);
            this.groupBox5.Controls.Add(this.btn_them);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(2, 590);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(436, 300);
            this.groupBox5.TabIndex = 15;
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
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Location = new System.Drawing.Point(99, 161);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(200, 50);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Enabled = false;
            this.btn_sua.Location = new System.Drawing.Point(99, 95);
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
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(200, 50);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(21, 402);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(388, 86);
            this.txt_mota.TabIndex = 14;
            // 
            // dtp_ngaykt
            // 
            this.dtp_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaykt.Location = new System.Drawing.Point(229, 329);
            this.dtp_ngaykt.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaykt.Name = "dtp_ngaykt";
            this.dtp_ngaykt.Size = new System.Drawing.Size(180, 31);
            this.dtp_ngaykt.TabIndex = 13;
            // 
            // dtp_ngaybd
            // 
            this.dtp_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaybd.Location = new System.Drawing.Point(21, 329);
            this.dtp_ngaybd.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaybd.Name = "dtp_ngaybd";
            this.dtp_ngaybd.Size = new System.Drawing.Size(180, 31);
            this.dtp_ngaybd.TabIndex = 12;
            // 
            // txt_sotien
            // 
            this.txt_sotien.Location = new System.Drawing.Point(229, 258);
            this.txt_sotien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sotien.Name = "txt_sotien";
            this.txt_sotien.Size = new System.Drawing.Size(180, 31);
            this.txt_sotien.TabIndex = 11;
            this.txt_sotien.Text = "0";
            this.txt_sotien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_sotien_MouseClick);
            this.txt_sotien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sotien_KeyPress);
            // 
            // txt_phantram
            // 
            this.txt_phantram.Location = new System.Drawing.Point(21, 258);
            this.txt_phantram.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phantram.Name = "txt_phantram";
            this.txt_phantram.Size = new System.Drawing.Size(180, 31);
            this.txt_phantram.TabIndex = 10;
            this.txt_phantram.Text = "0";
            this.txt_phantram.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_phantram_MouseClick);
            this.txt_phantram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phantram_KeyPress);
            // 
            // txt_dkgiam
            // 
            this.txt_dkgiam.Location = new System.Drawing.Point(21, 138);
            this.txt_dkgiam.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dkgiam.Multiline = true;
            this.txt_dkgiam.Name = "txt_dkgiam";
            this.txt_dkgiam.Size = new System.Drawing.Size(388, 76);
            this.txt_dkgiam.TabIndex = 9;
            // 
            // txt_tenkm
            // 
            this.txt_tenkm.Location = new System.Drawing.Point(21, 70);
            this.txt_tenkm.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenkm.Name = "txt_tenkm";
            this.txt_tenkm.Size = new System.Drawing.Size(312, 31);
            this.txt_tenkm.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền giảm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phần trăm giảm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điều kiện giảm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khuyến mãi";
            // 
            // Frm_QL_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 920);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_QL_KhuyenMai";
            this.Text = "Frm_QL_KhuyenMai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_khuyenmai)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
		private GroupBox groupBox1;
		private GroupBox groupBox4;
		private DataGridView dtg_view_khuyenmai;
		private GroupBox groupBox3;
		private RadioButton rd_hethan;
		private RadioButton rd_dangdung;
		private RadioButton rd_chuadung;
		private RadioButton rd_tatca;
		private TextBox txt_timkiem;
		private GroupBox groupBox2;
		private TextBox txt_mota;
		private DateTimePicker dtp_ngaykt;
		private DateTimePicker dtp_ngaybd;
		private TextBox txt_sotien;
		private TextBox txt_phantram;
		private TextBox txt_dkgiam;
		private TextBox txt_tenkm;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
        private GroupBox groupBox5;
        private Button btn_clear;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private CheckBox cb_sudung;
        private Label label8;
    }
}