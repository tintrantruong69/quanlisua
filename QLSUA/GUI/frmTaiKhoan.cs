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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            loadtk();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
           
        }

        private void dgTK_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgTK.Rows[dgTK.SelectedCells[0].RowIndex];
            txtID.Text = dr.Cells[0].Value.ToString();
            txtMK.Text = dr.Cells[1].Value.ToString();
            cbQuyen.Text = dr.Cells["quyen"].Value.ToString();
           
        }
        void loadtk()
        {
            List<TaiKhoan_DTO> lsttk = TaiKhoan_BUS.LayTaiKhoan();
            dgTK.DataSource = lsttk;
            List<NhanVien_DTO> lstNhanvien = NhanVien_BUS.LayNhanVien();
            cbQuyen.DataSource = lstNhanvien;

            cbQuyen.DisplayMember = "tencv";
            cbQuyen.ValueMember = "id";



            dgTK.Columns["Manv"].HeaderText = "Mã nhân viên";

            dgTK.Columns["Matkhau"].HeaderText = "Mật khẩu";

            //dgTK.Columns["Tencv"].HeaderText = "Chức vụ";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtMK.Text == "" || cbQuyen.Text == "")
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin.");
                return;
            }
            if (txtID.TextLength > 5)
            {
                MessageBox.Show("Mã nhân viên có chiều dài không quá 5 ký tự.");
                return;
            }


            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            //tk.SID = int.Parse(txtID.Text);
            tk.Manv = txtID.Text;
            tk.Matkhau = txtMK.Text;
            tk.Quyen = cbQuyen.Text == "Quản lý" ? 0 : 1;
           if (TaiKhoan_BUS.ThemTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;

            }
            loadtk();
            MessageBox.Show("Đã thêm tài khoản mới.");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Manv = txtID.Text;
            tk.Matkhau = txtMK.Text;
           
            if (TaiKhoan_BUS.SuaTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            loadtk();
            MessageBox.Show("Đã sửa thành công.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Manv = txtID.Text;
            tk.Matkhau = txtMK.Text;

            if (TaiKhoan_BUS.XoaTaikhoan(tk) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            loadtk();
            MessageBox.Show("Đã xóa thành công.");
        }
    }
}

