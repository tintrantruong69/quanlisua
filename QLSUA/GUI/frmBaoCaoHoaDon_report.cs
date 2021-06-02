using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaoCaoHoaDon_report : Form
    {
        public frmBaoCaoHoaDon_report()
        {
            InitializeComponent();
        }

        private void frmBaoCaoHoaDon_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLSUADataSet.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.QLSUADataSet.hoadon);

            this.reportViewer1.RefreshReport();
        }
    }
}
