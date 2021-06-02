using BUS;
using DTO;
using DTO.Common;
using DTO.SanPhamViewModel;
using GUI.Dialog;
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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            LoadDanhSachSanPham();
        }

        List<SanPham_DTO> _dsSanPham = new List<SanPham_DTO>();
        List<GioHang_DTO> _sanPhamTrongGio = new List<GioHang_DTO>();
      
        private void LoadDanhSachSanPham()
        {

            _dsSanPham = SanPham_BUS.LaySanPham();
            dgv_SanPham.DataSource = null;
            dgv_SanPham.DataSource = _dsSanPham;

            

            //dgv_GioHang.Columns["MaSP"].HeaderText = "Mã sản phẩm";

            //dgv_GioHang.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            //dgv_GioHang.Columns["TongTien"].HeaderText = "Thành tiền";
            //dgv_GioHang.Columns["SoLuongMua"].HeaderText = "Số lượng mua";

            //dgv_SanPham.Columns["Tensp"].HeaderText = "Tên sản phẩm";
            //dgv_SanPham.Columns["Dongiaban"].HeaderText = "Đơn giá bán";
            //dgv_SanPham.Columns["Soluong"].HeaderText = "Số lượng";

            //dgv_SanPham.Columns["idloaisp"].HeaderText = "Mã loại sản phẩm";
            //dgv_SanPham.Columns["Tenloai"].HeaderText = "Tên loại";
            //dgv_SanPham.Columns["MaPn"].HeaderText = "Mã phiếu nhập";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgv_SanPham.CurrentRow.Index < 0) return;
            //sanPham => sản phẩm trong danh sách bán
            var sanpham = _dsSanPham.FirstOrDefault(x => x.Masp == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanpham.Soluong < 1)  return; //nếu hết hàng thì không cho thêm vào giỏ hàng nữa.
       

            //sanphamTG => Sản phẩm trong giỏ hàng
            var sanphamTG = _sanPhamTrongGio.FirstOrDefault(x => x.MaSP == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanphamTG != null)
            {
                sanphamTG.SoLuongMua++;
                sanphamTG.TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}") * sanphamTG.SoLuongMua;
          
                sanpham.Soluong--;
            }
            else
            {
                var sp = new GioHang_DTO()
                {
                    MaSP = $"{dgv_SanPham.CurrentRow.Cells["Masp"].Value}",
                    TenSP = $"{dgv_SanPham.CurrentRow.Cells["TenSP"].Value}",
                    SoLuongMua = 1,
                    TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}"),
                    //ThanhTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["ThanhTien"].Value}")
                };
                ;
                sanpham.Soluong--;
                _sanPhamTrongGio.Add(sp);
            }
            //Cập nhật giỏ hàng
            dgv_GioHang.DataSource = null;
            dgv_GioHang.DataSource = _sanPhamTrongGio;
            //Cập nhật danh sách bán
            dgv_SanPham.DataSource = null;
            dgv_SanPham.DataSource = _dsSanPham;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var kh = new KhachHangDialog();
            if (kh.ShowDialog() != DialogResult.OK) return;
            var thanhToan = new ThanhToan_BUS();
            var kq = thanhToan.ThanhToan(_sanPhamTrongGio, kh._MaKH, ThongTin.NhanVien.Manv);
            if (kq)
                MessageBox.Show("Thanh toán thành công");
            else
                MessageBox.Show("Thanh toán thất bại");
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void dgv_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bthThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_GioHang.CurrentRow.Index < 0) return;
            //sanPham => sản phẩm trong danh sách bán
            var sanpham = _dsSanPham.FirstOrDefault(x => x.Masp == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanpham.Soluong < 1) return; //nếu hết hàng thì không cho thêm vào giỏ hàng nữa.


            //sanphamTG => Sản phẩm trong giỏ hàng
            var sanphamTG = _sanPhamTrongGio.FirstOrDefault(x => x.MaSP == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanphamTG != null)
            {
                sanphamTG.SoLuongMua--;
                sanphamTG.TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}") * sanphamTG.SoLuongMua;

                sanpham.Soluong++;
            }
            else
            {
                var sp = new GioHang_DTO()
                {
                    MaSP = $"{dgv_SanPham.CurrentRow.Cells["Masp"].Value}",
                    TenSP = $"{dgv_SanPham.CurrentRow.Cells["TenSP"].Value}",
                    SoLuongMua = 1,
                    TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}"),
                    //ThanhTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["ThanhTien"].Value}")
                };
                ;
                sanpham.Soluong++;
                _sanPhamTrongGio.Remove(sp);
                
            }
            //Cập nhật lại giỏ hàng
            dgv_GioHang.DataSource = null;
            dgv_GioHang.DataSource = _sanPhamTrongGio;
            //Cập nhật lại danh sách bán
            dgv_SanPham.DataSource = null;
            dgv_SanPham.DataSource = _dsSanPham;

        }

        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

