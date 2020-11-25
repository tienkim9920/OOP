using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            CongTy congTy = new CongTy();

            Console.WriteLine($"Muc Dong Gop Chuan Cua Cong Ty: {congTy.MucDongGopChuan}");

            NhanVien nhanVien1 = new NhanVien("18DH110638", 300000, "Nguyen Kim Tien", "21");
            NhanVien nhanVien2 = new NhanVien("18DH110639", 300000, "Le Thi Thuy Linh", "21");

            congTy.ThemNhanVien(nhanVien1);
            congTy.ThemNhanVien(nhanVien2);

            congTy.KiemTraNhanVien();

            congTy.DanhSachNhanVien();

            if (congTy.VonDieuLe() > 0)
            {
                Console.WriteLine("Cong Ty Chua Pha San");
            }
            else
            {
                Console.WriteLine("Cong Ty Da Pha San");
            }
        }
    }
}
