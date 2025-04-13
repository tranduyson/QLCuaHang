﻿namespace GUI
{
    partial class frmSanPham
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
            dataGridViewSanPham = new DataGridView();
            btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            txtTimKiem = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSanPham
            // 
            dataGridViewSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSanPham.Location = new Point(25, 188);
            dataGridViewSanPham.Name = "dataGridViewSanPham";
            dataGridViewSanPham.RowHeadersWidth = 51;
            dataGridViewSanPham.Size = new Size(903, 242);
            dataGridViewSanPham.TabIndex = 0;
            dataGridViewSanPham.CellContentClick += dataGridViewSanPham_CellContentClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTimKiem.Depth = 0;
            btnTimKiem.HighEmphasis = true;
            btnTimKiem.Icon = null;
            btnTimKiem.Location = new Point(770, 129);
            btnTimKiem.Margin = new Padding(4, 6, 4, 6);
            btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.NoAccentTextColor = Color.Empty;
            btnTimKiem.Size = new Size(158, 36);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTimKiem.UseAccentColor = false;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click_1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AnimateReadOnly = false;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Depth = 0;
            txtTimKiem.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTimKiem.LeadingIcon = null;
            txtTimKiem.Location = new Point(25, 129);
            txtTimKiem.MaxLength = 50;
            txtTimKiem.MouseState = MaterialSkin.MouseState.OUT;
            txtTimKiem.Multiline = false;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(724, 50);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "";
            txtTimKiem.TrailingIcon = null;
            txtTimKiem.TextChanged += materialTextBox1_TextChanged;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 517);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dataGridViewSanPham);
            Name = "frmSanPham";
            Text = "frmSanPham";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSanPham;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private MaterialSkin.Controls.MaterialTextBox txtTimKiem;
    }
}