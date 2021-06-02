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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            LoadSanPham();
           
        }

        void LoadSanPham()
        {
            List<SanPham_DTO> lstSanPham = SanPham_BUS.LaySanPham();
            dgDSSP.DataSource = lstSanPham;

            List<LoaiSP_DTO> lstLoaiSP = LoaiSP_BUS.LayLoai();
            cbLoaiSP.DataSource = lstLoaiSP;
            cbLoaiSP.DisplayMember = "tenloai";
            cbLoaiSP.ValueMember = "maloai";

            dgDSSP.Columns["Masp"].HeaderText = "Mã sản phẩm";

            dgDSSP.Columns["Tensp"].HeaderText = "Tên sản phẩm";
            dgDSSP.Columns["Dongiaban"].HeaderText = "Đơn giá bán";
            dgDSSP.Columns["Soluong"].HeaderText = "Số lượng";

            dgDSSP.Columns["idloaisp"].HeaderText = "Mã loại sản phẩm";
            dgDSSP.Columns["Tenloai"].HeaderText = "Tên loại";
            dgDSSP.Columns["MaPn"].HeaderText = "Mã phiếu nhập";

          

            


        }

        

        private void SanPham_Load(object sender, EventArgs e)
        {

        }

        private void dgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgDSSP.CurrentRow;

            // Chuyển giá trị lên form

            txtMaSP.Text = row.Cells["masp"].Value.ToString();
            txtTenSP.Text = row.Cells["tensp"].Value.ToString();
            txtSL.Text = row.Cells["soluong"].Value.ToString();

            txtDGBan.Text = row.Cells["dongiaban"].Value.ToString();
            cbLoaiSP.Text = row.Cells["tenloai"].Value.ToString();

            txtPN.Text = row.Cells["maPn"].Value.ToString();
            

        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

            if (SanPham_BUS.ThemSP(int.Parse(txtPN.Text), txtMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtDGBan.Text), cbLoaiSP.SelectedValue.ToString()))
                MessageBox.Show("Thành công", "Thông báo");


            else

                MessageBox.Show("Không thêm được.");

            LoadSanPham();

        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.MaPn = int.Parse(txtPN.Text);
            sp.Masp = txtMaSP.Text;
            sp.Tensp = txtTenSP.Text;
            sp.Soluong = int.Parse(txtSL.Text);
            sp.Dongiaban = int.Parse(txtDGBan.Text);

            if (SanPham_BUS.SuaSanPham(sp) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo");
            LoadSanPham();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            SanPham_DTO sp = new SanPham_DTO();
            sp.MaPn = int.Parse( txtPN.Text);
            sp.Masp = txtMaSP.Text;
            sp.Tensp = txtTenSP.Text;
            sp.Soluong = int.Parse(txtSL.Text);
            sp.Dongiaban = int.Parse(txtDGBan.Text);
            if (SanPham_BUS.XoaSanPham(sp) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            LoadSanPham();
            MessageBox.Show("Đã xóa thành công.");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            List<SanPham_DTO> lstsp = SanPham_BUS.TimSPTheoTen(ten);
            if (lstsp == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSSP.DataSource = lstsp;


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //private void btnThemSP_Click(object sender, EventArgs e)
        //{
        //    if (SanPham_BUS.ThemSP(txtMaSP.Text, txtTenSP.Text, txtSL.Text, txtDGBan.Text, cbLoaiSP.SelectedValue.ToString()))
        //        MessageBox.Show("Thành công", "Thông báo");


        //    else

        //        MessageBox.Show("Không thêm được.");

        //    LoadSanPham();
        //    LoadTB();

        //}

        //private void btnSuaSP_Click(object sender, EventArgs e)
        //{
        //    if (SanPham_BUS.SuaSP(txtMaSP.Text, txtTenSP.Text, txtSL.Text, txtDGBan.Text, cbLoaiSP.SelectedValue.ToString()))
        //    {
        //        MessageBox.Show("Thành công", "Thông báo");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không Sửa được.");
        //    }
        //    LoadSanPham();
        //    LoadTB();
        //}
    }
    }

