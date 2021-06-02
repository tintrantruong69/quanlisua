
namespace GUI
{
    partial class frmDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(271, 110);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(246, 26);
            this.txtMaNV.TabIndex = 2;
            this.txtMaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(271, 142);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(246, 26);
            this.txtMK.TabIndex = 2;
            this.txtMK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(266, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.milk;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 137);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnHUY
            // 
            this.btnHUY.BackColor = System.Drawing.Color.Lime;
            this.btnHUY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUY.ForeColor = System.Drawing.Color.Brown;
            this.btnHUY.Image = global::GUI.Properties.Resources.exit3;
            this.btnHUY.Location = new System.Drawing.Point(373, 186);
            this.btnHUY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(144, 56);
            this.btnHUY.TabIndex = 3;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHUY.UseVisualStyleBackColor = false;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.Lime;
            this.btnDN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.Color.Brown;
            this.btnDN.Image = global::GUI.Properties.Resources.login2;
            this.btnDN.Location = new System.Drawing.Point(157, 186);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(195, 56);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(550, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHUY);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnHUY;
        public System.Windows.Forms.TextBox txtMaNV;
        public System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}