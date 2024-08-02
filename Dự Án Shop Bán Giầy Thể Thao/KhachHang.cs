using BUS_DuAn.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    public partial class KhachHang : Form
    {
        Service_KhachHang svkh;
        public KhachHang()
        {
            InitializeComponent();
            svkh = new Service_KhachHang();
            LoadData();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dtgView_KhachHang.ColumnCount = 6;
            dtgView_KhachHang.Columns[1].Name = "Mã NV";
            dtgView_KhachHang.Columns[2].Name = "Tên NV";
            dtgView_KhachHang.Columns[5].Name = "Địa Chỉ";
            dtgView_KhachHang.Columns[6].Name = "Email";
            dtgView_KhachHang.Columns[3].Name = "Số Điện Thoại";
            dtgView_KhachHang.Columns[8].Name = "Giới Tính";
            dtgView_KhachHang.Rows.Clear();
            foreach (var kh in svkh.GetKhachHangs())
            {
                dtgView_KhachHang.Rows.Add(kh.MaKhachHang,kh.TenKhachHang,kh.DiaChi,kh.Email,kh.SoDienThoai,kh.GioiTinh);
            }
        }
    }
}
