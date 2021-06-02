
namespace GUI
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bthThemKH = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AllowUserToAddRows = false;
            this.dgv_SanPham.AllowUserToDeleteRows = false;
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(48, 29);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.ReadOnly = true;
            this.dgv_SanPham.RowHeadersVisible = false;
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.Size = new System.Drawing.Size(1513, 231);
            this.dgv_SanPham.TabIndex = 0;
            this.dgv_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellContentClick);
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.AllowUserToAddRows = false;
            this.dgv_GioHang.AllowUserToDeleteRows = false;
            this.dgv_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Location = new System.Drawing.Point(48, 40);
            this.dgv_GioHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.ReadOnly = true;
            this.dgv_GioHang.RowHeadersVisible = false;
            this.dgv_GioHang.RowHeadersWidth = 51;
            this.dgv_GioHang.Size = new System.Drawing.Size(1508, 231);
            this.dgv_GioHang.TabIndex = 0;
            this.dgv_GioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GioHang_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_GioHang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(18, 428);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1620, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(730, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_SanPham);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(18, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1620, 278);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // bthThemKH
            // 
            this.bthThemKH.BackColor = System.Drawing.Color.Lime;
            this.bthThemKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bthThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bthThemKH.Image = global::GUI.Properties.Resources.khách_hàng1;
            this.bthThemKH.Location = new System.Drawing.Point(976, 358);
            this.bthThemKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bthThemKH.Name = "bthThemKH";
            this.bthThemKH.Size = new System.Drawing.Size(458, 69);
            this.bthThemKH.TabIndex = 5;
            this.bthThemKH.Text = "Thêm khách hàng thanh toán";
            this.bthThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bthThemKH.UseVisualStyleBackColor = false;
            this.bthThemKH.Click += new System.EventHandler(this.bthThemKH_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(655, 358);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(299, 69);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Lime;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::GUI.Properties.Resources.exit2;
            this.btnXoa.Location = new System.Drawing.Point(435, 356);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(182, 62);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::GUI.Properties.Resources.loaisanpham1;
            this.btnThem.Location = new System.Drawing.Point(66, 355);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(342, 62);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Chọn Sản phẩm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Lime;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = global::GUI.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(1454, 358);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 69);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1656, 756);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bthThemKH);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button bthThemKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
    }
}