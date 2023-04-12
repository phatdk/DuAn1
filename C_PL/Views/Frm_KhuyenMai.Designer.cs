namespace C_PL.Views
{
    partial class Frm_KhuyenMai
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
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_khuyenmai)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1290, 736);
            this.groupBox1.TabIndex = 1;
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
            this.groupBox4.Size = new System.Drawing.Size(1286, 596);
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
            this.dtg_view_khuyenmai.Size = new System.Drawing.Size(1282, 568);
            this.dtg_view_khuyenmai.TabIndex = 0;
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
            this.groupBox3.Size = new System.Drawing.Size(1286, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // rd_hethan
            // 
            this.rd_hethan.AutoSize = true;
            this.rd_hethan.Location = new System.Drawing.Point(501, 29);
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
            this.rd_dangdung.Location = new System.Drawing.Point(298, 29);
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
            this.rd_chuadung.Location = new System.Drawing.Point(97, 29);
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
            this.rd_tatca.Location = new System.Drawing.Point(8, 29);
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
            // Frm_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 736);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_KhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_KhuyenMai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_khuyenmai)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
    }
}