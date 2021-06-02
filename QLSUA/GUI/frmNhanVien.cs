using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
       
        public frmNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadTB();


        }
        void LoadNhanVien()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dgDSnv.DataSource = lstNhanVien;

            cbChucvu.DataSource = lstNhanVien;
            cbChucvu.DisplayMember = "tencv";
            cbChucvu.ValueMember = "tencv";


            dgDSnv.Columns["Id"].HeaderText = "Mã nhân viên";

            dgDSnv.Columns["Hoten"].HeaderText = "Họ tên";
            dgDSnv.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgDSnv.Columns["Sdt"].HeaderText = "Số điện thoại";
            //dgDSnv.Columns["Dtngasinh"].HeaderText = "Ngày sinh";
            dgDSnv.Columns["Cmnd"].HeaderText = "Chứng minh nhân dân";
            dgDSnv.Columns["Diachi"].HeaderText = "Địa chỉ";
            dgDSnv.Columns["Tencv"].HeaderText = "Chức vụ";
        }

        void LoadTB()
        {
            txtManv.DataBindings.Clear();
            txtManv.DataBindings.Add("Text", dgDSnv.DataSource, "ID");

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgDSnv.DataSource, "hoten");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgDSnv.DataSource, "diachi");



            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgDSnv.DataSource, "cmnd");


            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgDSnv.DataSource, "sdt");




            cbChucvu.DataBindings.Clear();
            cbChucvu.DataBindings.Add("Text", dgDSnv.DataSource, "tencv");

            
        }

       /* private void dgDSnv_Click(object sender, EventArgs e)
        {
           *//* DataGridViewRow row = new DataGridViewRow();
            row = dgDSnv.CurrentRow;
            txtManv.Text = row.Cells["id"].Value.ToString();
            txtHoten.Text = row.Cells["hoten"].Value.ToString();
            txtCMND.Text = row.Cells["cmnd"].Value.ToString();
            txtSDT.Text = row.Cells["sdt"].Value.ToString();
            txtDiachi.Text = row.Cells["diachi"].Value.ToString();
            cbChucvu.Text = row.Cells["chucvu"].Selected.ToString();
            if (row.Cells["gioitinh"].Value.ToString() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            Dtngaysinh.Text = row.Cells["dtngaysinh"].Value.ToString();*//*

            List<ChucVu_DTO> nv = ChucVu_BUS.LayChucVu();
            cbChucvu.DataSource = nv;
            cbChucvu.DisplayMember = "tencv";
            cbChucvu.ValueMember = "maCV";


        }*/


        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtManv.Text == "" || txtHoten.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtManv.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtManv.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            // k co chuc vu t de choi
            if (NhanVien_BUS.ThemNhanVien(txtManv.Text, txtHoten.Text, gioitinh, Dtngaysinh.Value.ToShortDateString(), txtCMND.Text, txtDiachi.Text, txtSDT.Text,cbChucvu.SelectedValue.ToString()))
                MessageBox.Show("Thành công", "Thông báo");
           
            
            else
            
                MessageBox.Show("Không thêm được.");
                
            LoadNhanVien();
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhanVien_BUS.XoaNhanVien(txtManv.Text))
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadNhanVien();
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = txtManv.Text;
                nv.Hoten = txtHoten.Text;
                if (rdNam.Checked == true)
                    nv.Gioitinh = "Nam";
                else
                    nv.Gioitinh = "Nữ";
                nv.Dtngaysinh = DateTime.Parse(Dtngaysinh.Text);
                nv.Cmnd = txtCMND.Text;

                nv.Diachi = txtDiachi.Text;
                nv.Sdt = txtSDT.Text;
                nv.Tencv = cbChucvu.SelectedValue.ToString();
                if (NhanVien_BUS.SuaNhanVien(nv) == false)
                {
                    MessageBox.Show("Không sửa được.");
                    return;
                }

            LoadNhanVien();
            }

        

        private void frmNhanVien_Shown(object sender, EventArgs e)
        {
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
