namespace GUI
{
    partial class frmBaoCaoHoaDon_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSUADataSet = new GUI.QLSUADataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.hoadonTableAdapter = new GUI.QLSUADataSetTableAdapters.hoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSUADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.QLSUADataSet;
            // 
            // QLSUADataSet
            // 
            this.QLSUADataSet.DataSetName = "QLSUADataSet";
            this.QLSUADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "QuanLySua";
            reportDataSource1.Value = this.hoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.reportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 343);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo hóa đơn";
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoHoaDon_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoHoaDon_report";
            this.Text = "frmBaoCaoHoaDon_report";
            this.Load += new System.EventHandler(this.frmBaoCaoHoaDon_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSUADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private QLSUADataSet QLSUADataSet;
        private QLSUADataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter;
    }
}