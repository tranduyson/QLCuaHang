namespace GUI
{
    partial class frmBCDoanhThuTheoNgay
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
            datTuNgay = new DateTimePicker();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            datDenNgay = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dgDoanhThuTheoNgay = new DataGridView();
            btnXoa = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgDoanhThuTheoNgay).BeginInit();
            SuspendLayout();
            // 
            // datTuNgay
            // 
            datTuNgay.Format = DateTimePickerFormat.Custom;
            datTuNgay.Location = new Point(141, 45);
            datTuNgay.Margin = new Padding(3, 4, 3, 4);
            datTuNgay.Name = "datTuNgay";
            datTuNgay.Size = new Size(162, 27);
            datTuNgay.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = false;
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(689, 34);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(93, 36);
            btnTimKiem.TabIndex = 38;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // datDenNgay
            // 
            datDenNgay.Format = DateTimePickerFormat.Custom;
            datDenNgay.Location = new Point(483, 40);
            datDenNgay.Margin = new Padding(3, 4, 3, 4);
            datDenNgay.Name = "datDenNgay";
            datDenNgay.Size = new Size(162, 27);
            datDenNgay.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 50);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 40;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 45);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 41;
            label2.Text = "Đến ngày";
            // 
            // dgDoanhThuTheoNgay
            // 
            dgDoanhThuTheoNgay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDoanhThuTheoNgay.Location = new Point(30, 112);
            dgDoanhThuTheoNgay.Name = "dgDoanhThuTheoNgay";
            dgDoanhThuTheoNgay.RowHeadersWidth = 51;
            dgDoanhThuTheoNgay.Size = new Size(924, 491);
            dgDoanhThuTheoNgay.TabIndex = 42;
            
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = false;
            btnXoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnXoa.Depth = 0;
            btnXoa.Enabled = false;
            btnXoa.HighEmphasis = true;
            btnXoa.Icon = null;
            btnXoa.Location = new Point(806, 34);
            btnXoa.Margin = new Padding(5);
            btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            btnXoa.Name = "btnXoa";
            btnXoa.NoAccentTextColor = Color.Empty;
            btnXoa.Size = new Size(137, 36);
            btnXoa.TabIndex = 66;
            btnXoa.Text = "In Danh sách";
            btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnXoa.UseAccentColor = false;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // frmBCDoanhThuTheoNgay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 679);
            Controls.Add(btnXoa);
            Controls.Add(dgDoanhThuTheoNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datDenNgay);
            Controls.Add(btnTimKiem);
            Controls.Add(datTuNgay);
            Name = "frmBCDoanhThuTheoNgay";
            Text = "Doanh thu theo ngày";
            ((System.ComponentModel.ISupportInitialize)dgDoanhThuTheoNgay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datTuNgay;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private DateTimePicker datDenNgay;
        private Label label1;
        private Label label2;
        private DataGridView dgDoanhThuTheoNgay;
        private MaterialSkin.Controls.MaterialButton btnXoa;
    }
}