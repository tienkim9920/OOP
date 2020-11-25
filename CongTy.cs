using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class CongTy : NhanVien
    {

        List<NhanVien> nhanViens = new List<NhanVien>();
        List<NhanVien> nhanVienTemp = new List<NhanVien>();

        private string tenCongTy;
        private int mucDongGopChuan;
        private int nganSachHienTai;
        private int nguonThuTheoThang;
        private int nguonChiTheoThang;

        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }
        public int MucDongGopChuan { get => mucDongGopChuan; set => mucDongGopChuan = value; }
        public int NganSachHienTai { get => nganSachHienTai; set => nganSachHienTai = value; }
        public int NguonThuTheoThang { get => nguonThuTheoThang; set => nguonThuTheoThang = value; }
        public int NguonChiTheoThang { get => nguonChiTheoThang; set => nguonChiTheoThang = value; }

        public void ThemNhanVien()
        {
            nhanViens = new List<NhanVien>();

            NhanVien nhanVien = new NhanVien();

            Console.Write("Nhap Ho Ten: ");
            nhanVien.HoTen = Console.ReadLine();

            Console.Write("Nhap Tuoi: ");
            nhanVien.Tuoi = Console.ReadLine();

            Console.Write("Nhap Ma Nhan Vien: ");
            nhanVien.MaNhanVien = Console.ReadLine();

            Console.Write("Nhap Luong: ");
            nhanVien.Luong = int.Parse(Console.ReadLine());

            Console.Write("Nhap Muc Dong Gop: ");
            nhanVien.MucDongGop = int.Parse(Console.ReadLine());

            nhanViens.Add(nhanVien);
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            nhanViens.Add(nhanVien);
            nhanVienTemp.Add(nhanVien);
        }

        public void XoaNhanVien(NhanVien nhanVien)
        {
            nhanViens.Remove(nhanVien);
        }

        public bool SaThaiNhanVien(NhanVien nhanVien)
        {
            if (nhanVien.MucDongGop < MucDongGopChuan)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public void KiemTraNhanVien()
        {
            foreach(NhanVien nhanVien in nhanVienTemp)
            {
                if (SaThaiNhanVien(nhanVien))
                {
                    Console.WriteLine($"Da Sa Thai Nhan Vien {nhanVien.HoTen}");
                    nhanViens.Remove(nhanVien);
                }
            }
        }

        public void DanhSachNhanVien()
        {
            foreach(NhanVien x in nhanViens)
            {
                Console.WriteLine($"Ho Ten: {x.HoTen}");
                Console.WriteLine($"Tuoi: {x.Tuoi}");
                Console.WriteLine($"Ma Nhan Vien: {x.MaNhanVien}");
                Console.WriteLine($"Luong: {x.Luong}");
                Console.WriteLine($"Muc Dong Gop: {x.MucDongGop}");
            }
        }

        public CongTy()
        {
            this.mucDongGopChuan = 40000;
            this.NganSachHienTai = 4000000;
            this.NguonChiTheoThang = 500000;
        }

        public CongTy(string MaNhanVien, int Luong, double MucDongGop, string HoTen, string Tuoi) : 
            base(MaNhanVien, Luong, HoTen, Tuoi)
        {

        }

        public double VonDieuLe()
        {
            double vonDieuLe = 0;

            double tongDongGop = 0;
            double tongLuong = 0;
            foreach (NhanVien nhanVien in nhanViens)
            {
                tongDongGop += nhanVien.MucDongGop;
                tongLuong += nhanVien.Luong;
            }

            vonDieuLe = NganSachHienTai + tongDongGop - NguonChiTheoThang - tongLuong;

            return vonDieuLe;
        }
    }
}
