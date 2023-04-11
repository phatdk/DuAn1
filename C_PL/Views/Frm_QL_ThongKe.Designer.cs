namespace C_PL.Views
{
    partial class Frm_QL_ThongKe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            cbbNam = new ComboBox();
            cbbThang = new ComboBox();
            panel2 = new Panel();
            dtg = new DataGridView();
            lbSPbanChay = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lb_DoanhThu = new Label();
            label1 = new Label();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            date_TheoNgay = new DateTimePicker();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1446, 589);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 22);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.3274F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.6726F));
            tableLayoutPanel1.Size = new Size(1442, 565);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(723, 388);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(717, 175);
            panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbbNam);
            groupBox3.Controls.Add(cbbThang);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(717, 175);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Theo tháng, năm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(231, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 46);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Tháng";
            // 
            // cbbNam
            // 
            cbbNam.FormattingEnabled = true;
            cbbNam.Location = new Point(239, 69);
            cbbNam.Margin = new Padding(2);
            cbbNam.Name = "cbbNam";
            cbbNam.Size = new Size(106, 28);
            cbbNam.TabIndex = 1;
            // 
            // cbbThang
            // 
            cbbThang.DisplayMember = "Chọn tháng";
            cbbThang.FormattingEnabled = true;
            cbbThang.Items.AddRange(new object[] { "Chọn tháng", "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cbbThang.Location = new Point(63, 69);
            cbbThang.Margin = new Padding(2);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(109, 28);
            cbbThang.TabIndex = 0;
            cbbThang.ValueMember = "Chọn tháng";
            cbbThang.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(dtg);
            panel2.Controls.Add(lbSPbanChay);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(737, 16);
            panel2.Margin = new Padding(16);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 354);
            panel2.TabIndex = 1;
            // 
            // dtg
            // 
            dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg.Location = new Point(3, 82);
            dtg.Name = "dtg";
            dtg.RowHeadersWidth = 51;
            dtg.RowTemplate.Height = 29;
            dtg.Size = new Size(300, 188);
            dtg.TabIndex = 13;
            // 
            // lbSPbanChay
            // 
            lbSPbanChay.AutoSize = true;
            lbSPbanChay.Font = new Font("Times New Roman", 50F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbSPbanChay.ForeColor = Color.Red;
            lbSPbanChay.Location = new Point(244, 260);
            lbSPbanChay.Margin = new Padding(2, 0, 2, 0);
            lbSPbanChay.Name = "lbSPbanChay";
            lbSPbanChay.Size = new Size(301, 94);
            lbSPbanChay.TabIndex = 12;
            lbSPbanChay.Text = "0_VND";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(689, 43);
            label2.TabIndex = 1;
            label2.Text = "Sản phẩm bán chạy";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(lb_DoanhThu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(16);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 354);
            panel1.TabIndex = 0;
            // 
            // lb_DoanhThu
            // 
            lb_DoanhThu.AutoSize = true;
            lb_DoanhThu.Font = new Font("Times New Roman", 50F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_DoanhThu.ForeColor = Color.Red;
            lb_DoanhThu.Location = new Point(230, 260);
            lb_DoanhThu.Margin = new Padding(2, 0, 2, 0);
            lb_DoanhThu.Name = "lb_DoanhThu";
            lb_DoanhThu.Size = new Size(301, 94);
            lb_DoanhThu.TabIndex = 11;
            lb_DoanhThu.Text = "0_VND";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(689, 50);
            label1.TabIndex = 0;
            label1.Text = "Doanh thu";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 388);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(717, 175);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(date_TheoNgay);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(8);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(717, 175);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Theo ngày";
            // 
            // date_TheoNgay
            // 
            date_TheoNgay.CustomFormat = "dd/MM/yyyy";
            date_TheoNgay.Format = DateTimePickerFormat.Short;
            date_TheoNgay.Location = new Point(64, 42);
            date_TheoNgay.Margin = new Padding(2);
            date_TheoNgay.Name = "date_TheoNgay";
            date_TheoNgay.Size = new Size(209, 27);
            date_TheoNgay.TabIndex = 0;
            date_TheoNgay.ValueChanged += date_TheoNgay_ValueChanged;
            // 
            // Frm_QL_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 589);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Frm_QL_ThongKe";
            Text = "Frm_QL_ThongKe";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private ComboBox cbbNam;
        private ComboBox cbbThang;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private GroupBox groupBox2;
        private DateTimePicker date_TheoNgay;
        private Label lb_DoanhThu;
        private Label lbSPbanChay;
        private DataGridView dtg;
    }
}