namespace PresentationTier
{
    partial class SanPhamForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView = new DataGridView();
            txtMaSP = new TextBox();
            txtXuatXu = new TextBox();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTenSp = new TextBox();
            cboDanhMuc = new ComboBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(65, 592);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 592);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 2;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCapNhat_Click;
            // 
            // button3
            // 
            button3.Location = new Point(765, 592);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 3;
            button3.Text = "Trở về";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnTroVe_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(42, 285);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(849, 277);
            dataGridView.TabIndex = 4;
            // 
            // txtMaSP
            // 
            txtMaSP.ForeColor = SystemColors.ActiveCaptionText;
            txtMaSP.Location = new Point(153, 81);
            txtMaSP.Margin = new Padding(3, 4, 3, 4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(231, 27);
            txtMaSP.TabIndex = 5;
            // 
            // txtXuatXu
            // 
            txtXuatXu.BackColor = SystemColors.Window;
            txtXuatXu.ForeColor = SystemColors.ControlText;
            txtXuatXu.Location = new Point(594, 147);
            txtXuatXu.Margin = new Padding(3, 4, 3, 4);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(231, 27);
            txtXuatXu.TabIndex = 6;
            // 
            // txtGia
            // 
            txtGia.ForeColor = SystemColors.ActiveCaptionText;
            txtGia.Location = new Point(594, 81);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(231, 27);
            txtGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BackColor = SystemColors.Window;
            txtSoLuong.ForeColor = SystemColors.ControlText;
            txtSoLuong.Location = new Point(153, 211);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(231, 27);
            txtSoLuong.TabIndex = 8;
            // 
            // txtTenSp
            // 
            txtTenSp.BackColor = SystemColors.Window;
            txtTenSp.ForeColor = SystemColors.ControlText;
            txtTenSp.Location = new Point(153, 147);
            txtTenSp.Margin = new Padding(3, 4, 3, 4);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(231, 27);
            txtTenSp.TabIndex = 9;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.BackColor = SystemColors.Window;
            cboDanhMuc.ForeColor = SystemColors.ControlText;
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(594, 211);
            cboDanhMuc.Margin = new Padding(3, 4, 3, 4);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(231, 28);
            cboDanhMuc.TabIndex = 10;
            cboDanhMuc.Text = "Danh muc";
            // 
            // button4
            // 
            button4.Location = new Point(369, 592);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 11;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnXoa_Click;
            // 
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 651);
            Controls.Add(button4);
            Controls.Add(cboDanhMuc);
            Controls.Add(txtTenSp);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(txtXuatXu);
            Controls.Add(txtMaSP);
            Controls.Add(dataGridView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SanPhamForm";
            Text = "Danh Sach San Pham";
            Load += SanPhamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView;
        private TextBox txtMaSP;
        private TextBox txtXuatXu;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private TextBox txtTenSp;
        private ComboBox cboDanhMuc;
        private Button button4;
    }
}