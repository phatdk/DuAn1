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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            dtg_view_hoadon = new DataGridView();
            groupBox2 = new GroupBox();
            dtg_view_chitiethoadon = new DataGridView();
            panel1 = new Panel();
            btn_inhd = new Button();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            txt_timkiem = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_hoadon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_chitiethoadon).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1018, 618);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý hóa đơn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtg_view_hoadon);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(2, 84);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(854, 210);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách hóa đơn";
            // 
            // dtg_view_hoadon
            // 
            dtg_view_hoadon.BackgroundColor = Color.White;
            dtg_view_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_hoadon.Dock = DockStyle.Fill;
            dtg_view_hoadon.Location = new Point(2, 22);
            dtg_view_hoadon.Margin = new Padding(2);
            dtg_view_hoadon.Name = "dtg_view_hoadon";
            dtg_view_hoadon.RowHeadersWidth = 62;
            dtg_view_hoadon.RowTemplate.Height = 33;
            dtg_view_hoadon.Size = new Size(850, 186);
            dtg_view_hoadon.TabIndex = 0;
            dtg_view_hoadon.CellClick += dtg_view_hoadon_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_view_chitiethoadon);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(2, 294);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(854, 322);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dtg_view_chitiethoadon
            // 
            dtg_view_chitiethoadon.BackgroundColor = Color.White;
            dtg_view_chitiethoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_chitiethoadon.Dock = DockStyle.Fill;
            dtg_view_chitiethoadon.Location = new Point(2, 22);
            dtg_view_chitiethoadon.Margin = new Padding(2);
            dtg_view_chitiethoadon.Name = "dtg_view_chitiethoadon";
            dtg_view_chitiethoadon.RowHeadersWidth = 62;
            dtg_view_chitiethoadon.RowTemplate.Height = 33;
            dtg_view_chitiethoadon.Size = new Size(850, 298);
            dtg_view_chitiethoadon.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_inhd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(856, 84);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 532);
            panel1.TabIndex = 2;
            // 
            // btn_inhd
            // 
            btn_inhd.Location = new Point(22, 202);
            btn_inhd.Margin = new Padding(2);
            btn_inhd.Name = "btn_inhd";
            btn_inhd.Size = new Size(114, 46);
            btn_inhd.TabIndex = 0;
            btn_inhd.Text = "In hóa đơn";
            btn_inhd.UseVisualStyleBackColor = true;
            btn_inhd.Click += btn_inhd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(txt_timkiem);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(2, 22);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1014, 62);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(297, 24);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2023, 3, 24, 7, 58, 49, 0);
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(22, 24);
            txt_timkiem.Margin = new Padding(2);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm mã nv, mã hóa đơn,...";
            txt_timkiem.Size = new Size(262, 27);
            txt_timkiem.TabIndex = 0;
            // 
            // Frm_QL_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 618);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Frm_QL_HoaDon";
            Text = "Frm_QL_HoaDon";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_hoadon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_chitiethoadon).EndInit();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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