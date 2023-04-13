namespace C_PL.Views
{
    partial class Frm_QL_Ban
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
            dtg_view_ban = new DataGridView();
            groupBox3 = new GroupBox();
            tb_TimKiem = new TextBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            btn_clear = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            cb_trangthai = new ComboBox();
            txt_tenban = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_view_ban).BeginInit();
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
            groupBox1.Size = new Size(914, 531);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý bàn";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtg_view_ban);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(2, 74);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(558, 455);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách bàn";
            // 
            // dtg_view_ban
            // 
            dtg_view_ban.BackgroundColor = Color.White;
            dtg_view_ban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view_ban.Dock = DockStyle.Fill;
            dtg_view_ban.Location = new Point(2, 22);
            dtg_view_ban.Margin = new Padding(2);
            dtg_view_ban.Name = "dtg_view_ban";
            dtg_view_ban.RowHeadersWidth = 62;
            dtg_view_ban.RowTemplate.Height = 33;
            dtg_view_ban.Size = new Size(554, 431);
            dtg_view_ban.TabIndex = 0;
            dtg_view_ban.CellClick += dtg_view_ban_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb_TimKiem);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(2, 22);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(558, 52);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm";
            // 
            // tb_TimKiem
            // 
            tb_TimKiem.Location = new Point(15, 22);
            tb_TimKiem.Margin = new Padding(2);
            tb_TimKiem.Name = "tb_TimKiem";
            tb_TimKiem.Size = new Size(346, 27);
            tb_TimKiem.TabIndex = 0;
            tb_TimKiem.TextChanged += tb_TimKiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(cb_trangthai);
            groupBox2.Controls.Add(txt_tenban);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(560, 22);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(352, 507);
            groupBox2.TabIndex = 0;
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
            groupBox5.Location = new Point(2, 265);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(348, 240);
            groupBox5.TabIndex = 4;
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
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Items.AddRange(new object[] { "1", "2" });
            cb_trangthai.Location = new Point(21, 194);
            cb_trangthai.Margin = new Padding(2);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(311, 28);
            cb_trangthai.TabIndex = 3;
            // 
            // txt_tenban
            // 
            txt_tenban.Location = new Point(21, 128);
            txt_tenban.Margin = new Padding(2);
            txt_tenban.Name = "txt_tenban";
            txt_tenban.Size = new Size(311, 27);
            txt_tenban.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 172);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn";
            // 
            // Frm_QL_Ban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 531);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Frm_QL_Ban";
            Text = "Frm_QL_Ban";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_view_ban).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cb_trangthai;
        private TextBox txt_tenban;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private DataGridView dtg_view_ban;
        private GroupBox groupBox3;
        private TextBox tb_TimKiem;
        private GroupBox groupBox5;
        private Button btn_clear;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}