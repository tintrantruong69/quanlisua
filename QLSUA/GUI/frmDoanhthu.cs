using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
            
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            //var baoCao = new BaoCao_BUS();
            //var ketQuaBaoCao = baoCao.BaoCaoTrongNam(int.Parse(cbnam.Text));
            //textBox1.Text = $"{ketQuaBaoCao.DoanhThu}";

            var baoCao1 = new BaoCao_BUS();
            var ketQuaBaoCao1 = baoCao1.BaoCaoNgay(int.Parse(cbngay.Text), int.Parse(cbthang.Text), int.Parse(cbnam.Text));
            textBox1.Text = $"{ketQuaBaoCao1}";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void loadSP()
        {
            List<SP> lstSP = BaoCao_BUS.LaySP();
            dataGridView1.DataSource = lstSP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadSP();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbnam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
