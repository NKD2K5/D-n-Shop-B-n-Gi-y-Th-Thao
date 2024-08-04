using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    public partial class HoaDoncs : Form
    {
        public HoaDoncs()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void HoaDoncs_Load(object sender, EventArgs e)
        {

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            dtgView_HoaDon.ColumnCount = 2;
            dtgView_HoaDon.Columns[0].Name = "Thông tin";
            dtgView_HoaDon.Columns[1].Name = "Giá trị";
            dtgView_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void XuatHoaDon(string maHoaDon, string tenNhanVien, string tenKhachHang, string ngayLap, decimal tongTien, decimal soTienNhan, decimal tienThua)
        {
            txt_MaHoaDon.Text = maHoaDon;
            txt_TenNhanVien.Text = tenNhanVien;
            txt_TenKhachHang.Text = tenKhachHang;
            txt_NgayLap.Text = ngayLap;
            txt_TongTien.Text = tongTien.ToString();
            txt_TienKhachTra.Text = soTienNhan.ToString();
            txt_TienThua.Text = tienThua.ToString();

            dtgView_HoaDon.Rows.Clear();
            dtgView_HoaDon.Rows.Add("Mã hóa đơn", maHoaDon);
            dtgView_HoaDon.Rows.Add("Tên nhân viên", tenNhanVien);
            dtgView_HoaDon.Rows.Add("Tên khách hàng", tenKhachHang);
            dtgView_HoaDon.Rows.Add("Ngày lập", ngayLap);
            dtgView_HoaDon.Rows.Add("Tổng tiền", tongTien.ToString());
            dtgView_HoaDon.Rows.Add("Số tiền nhận", soTienNhan.ToString());
            dtgView_HoaDon.Rows.Add("Tiền thừa", tienThua.ToString());
        }
    }
}



    

