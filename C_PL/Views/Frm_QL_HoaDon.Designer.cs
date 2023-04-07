namespace C_PL.Views
{
    partial class Frm_QL_HoaDon
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
            this.dtg_view_hoadon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_view_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_inhd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_hoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_chitiethoadon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1273, 772);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_view_hoadon);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1067, 263);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // dtg_view_hoadon
            // 
            this.dtg_view_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dtg_view_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_view_hoadon.Location = new System.Drawing.Point(3, 27);
            this.dtg_view_hoadon.Name = "dtg_view_hoadon";
            this.dtg_view_hoadon.RowHeadersWidth = 62;
            this.dtg_view_hoadon.RowTemplate.Height = 33;
            this.dtg_view_hoadon.Size = new System.Drawing.Size(1061, 233);
            this.dtg_view_hoadon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_view_chitiethoadon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 402);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtg_view_chitiethoadon
            // 
            this.dtg_view_chitiethoadon.BackgroundColor = System.Drawing.Color.White;
            this.dtg_view_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view_chitiethoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_view_chitiethoadon.Location = new System.Drawing.Point(3, 27);
            this.dtg_view_chitiethoadon.Name = "dtg_view_chitiethoadon";
            this.dtg_view_chitiethoadon.RowHeadersWidth = 62;
            this.dtg_view_chitiethoadon.RowTemplate.Height = 33;
            this.dtg_view_chitiethoadon.Size = new System.Drawing.Size(1061, 372);
            this.dtg_view_chitiethoadon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_inhd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1070, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 665);
            this.panel1.TabIndex = 2;
            // 
            // btn_inhd
            // 
            this.btn_inhd.Location = new System.Drawing.Point(28, 253);
            this.btn_inhd.Name = "btn_inhd";
            this.btn_inhd.Size = new System.Drawing.Size(142, 57);
            this.btn_inhd.TabIndex = 0;
            this.btn_inhd.Text = "In hóa đơn";
            this.btn_inhd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1267, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 31);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 24, 7, 58, 49, 0);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(27, 30);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.PlaceholderText = "Tìm kiếm mã nv, mã hóa đơn,...";
            this.txt_timkiem.Size = new System.Drawing.Size(327, 31);
            this.txt_timkiem.TabIndex = 0;
            // 
            // Frm_QL_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 772);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_QL_HoaDon";
            this.Text = "Frm_QL_HoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_hoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view_chitiethoadon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_timkiem;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private Panel panel1;
        private DataGridView dtg_view_hoadon;
        private DataGridView dtg_view_chitiethoadon;
        private Button btn_inhd;
    }
}