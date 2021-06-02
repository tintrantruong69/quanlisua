using BUS;
using DTO;
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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
            LoadPN();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {

        }
        void LoadPN()
        {
            List<PhieuNhap_DTO> lstPN = PhieuNhap_BUS.LayPN();
            dgv_PhieuNhap.DataSource = lstPN;
            //dgv_ChiTietPhieuNhap.DataSource = lstPN;

           

            dgv_PhieuNhap.Columns["id"].HeaderText = "Mã phiếu nhập";
            dgv_PhieuNhap.Columns["tensp"].HeaderText = "Loại";
            dgv_PhieuNhap.Columns["dongia"].HeaderText = "Đơn giá nhập";
            dgv_PhieuNhap.Columns["ngaynhap"].HeaderText = "Ngày nhập";
            dgv_PhieuNhap.Columns["soluong"].HeaderText = "Số lượng";
           


        }
        void Loadtb()
        {
            
        }

        private void dgPhieuNhap_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dgv_ChiTietPhieuNhap.CurrentRow;

            //// Chuyển giá trị lên form
            
            //txtTenSP.Text = row.Cells[1].Value.ToString();
            //txtSL.Text = row.Cells[2].Value.ToString();
            //txtDonGia.Text = row.Cells[3].Value.ToString();
           
            //dtNgayNhap.Text = row.Cells[4].Value.ToString();
            //txtPhieuNhap.Text = row.Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PhieuNhap_BUS.ThemPN(0,txtTenSP.Text, txtSL.Text,  dtNgayNhap.Value.ToShortDateString(), txtDonGia.Text))
                MessageBox.Show("Thành công", "Thông báo");


            else

                MessageBox.Show("Không thêm được.");

            LoadPN();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (PhieuNhap_BUS.XoaPN(txtPhieuNhap.Text))
                MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadPN();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuNhap_DTO pn = new PhieuNhap_DTO();
            pn.Id = int.Parse(txtPhieuNhap.Text);
            pn.Tensp = txtTenSP.Text;
            pn.Soluong = txtSL.Text;
            pn.Ngaynhap = DateTime.Parse(dtNgayNhap.Text);
            pn.Dongia = txtDonGia.Text;
            if (PhieuNhap_BUS.SuaPn(pn) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            MessageBox.Show("Sửa phiếu nhập thành công!", "Thông báo");
            LoadPN();
        }

        private void dgv_PhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_PhieuNhap.CurrentRow.Index < 0) return;
            dgv_ChiTietPhieuNhap.DataSource = null;
            dgv_ChiTietPhieuNhap.DataSource = SanPham_BUS.LaySanPhamTrongPhieuNhap(int.Parse($"{dgv_PhieuNhap.CurrentRow.Cells["ID"].Value}"));

            


            //dgv_ChiTietPhieuNhap.Columns["Tensp"].Width = 250;

        }

        private void dgv_ChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_PhieuNhap_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_PhieuNhap.CurrentRow;

            // Chuyển giá trị lên form

            txtPhieuNhap.Text = row.Cells["id"].Value.ToString();
            txtTenSP.Text = row.Cells["tensp"].Value.ToString();
            txtDonGia.Text = row.Cells["dongia"].Value.ToString();
            dtNgayNhap.Text= row.Cells["ngaynhap"].Value.ToString();
            txtSL.Text = row.Cells["soluong"].Value.ToString();
           
        }

        private void dgv_PhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
