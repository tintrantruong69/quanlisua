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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadNCC();
        }
        void LoadNCC()
        {
            List<NhaCungCap_DTO> lstKH = NhaCungCap_BUS.LayNCC();
            dgvNhaCungCap.DataSource = lstKH;


            dgvNhaCungCap.Columns["Id"].HeaderText = "Mã nhà cung cấp";

            dgvNhaCungCap.Columns["Tennhacungcap1"].HeaderText = "Họ tên nhà cung cấp";
            dgvNhaCungCap.Columns["Sdt1"].HeaderText = "Số điện thoại";
            dgvNhaCungCap.Columns["Diachi1"].HeaderText = "Địa chỉ";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhaCungCap.CurrentRow;

            // Chuyển giá trị lên form

            txtMNCC.Text = row.Cells[0].Value.ToString();
            txtTenNCC.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMNCC.Text == "" || txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã  có độ dài chuỗi hợp lệ hay không
            if (txtMNCC.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã  có bị trùng không
            if (NhaCungCap_BUS.TimNCCTheoID(txtMNCC.Text) != null)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!");
                return;
            }

            if (NhaCungCap_BUS.ThemNCC(txtMNCC.Text, txtTenNCC.Text, txtSDT.Text,txtDiaChi.Text))
                MessageBox.Show("Thành công", "Thông báo");


            else

                MessageBox.Show("Không thêm được.");

            LoadNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhaCungCap_BUS.XoaNCC(txtMNCC.Text))
                MessageBox.Show("Xóa thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadNCC();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (NhaCungCap_BUS.SuaNCC(txtMNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text))
                MessageBox.Show("Sửa thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadNCC();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            List<NhaCungCap_DTO> lstncc = NhaCungCap_BUS.TimNCCTheoTen(ten);
            if (lstncc == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvNhaCungCap.DataSource = lstncc;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlai_Click(object sender, EventArgs e)
        {
            LoadNCC();
            txtTimKiem.Clear();
            this.Focus();
        }
    }
}
