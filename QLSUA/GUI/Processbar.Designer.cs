namespace GUI
{
    partial class frmProcessbar
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tmPercent = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.Location = new System.Drawing.Point(474, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cửa Hàng Sữa";
            // 
            // pnlProcess
            // 
            this.pnlProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlProcess.Location = new System.Drawing.Point(12, 174);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(509, 27);
            this.pnlProcess.TabIndex = 2;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoading.Location = new System.Drawing.Point(157, 134);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(107, 25);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading...";
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.Lime;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPower.Location = new System.Drawing.Point(206, 90);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(95, 41);
            this.btnPower.TabIndex = 4;
            this.btnPower.Text = "Start";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPercent.Location = new System.Drawing.Point(281, 134);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(49, 25);
            this.lblPercent.TabIndex = 5;
            this.lblPercent.Text = "0 %";
            // 
            // tmPercent
            // 
            this.tmPercent.Interval = 70;
            this.tmPercent.Tick += new System.EventHandler(this.tmPercent_Tick);
            // 
            // frmProcessbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(533, 213);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pnlProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcessbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProcess;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Timer tmPercent;
    }
}