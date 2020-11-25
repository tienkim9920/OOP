using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class NhanVien : ConNguoi
    {
        private string maNhanVien;
        private int luong;
        private double mucDongGop;

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }
            set
            {
                maNhanVien = value;
            }
        }

        public int Luong
        {
            get
            {
                return luong;
            }
            set
            {
                luong = value;
            }
        } 

        public double MucDongGop
        {
            get
            {
                return mucDongGop;
            }
            set
            {
                mucDongGop = value;
            }
        }

        public NhanVien(string maNhanVien, int luong, string hoTen, string tuoi) : base (hoTen, tuoi)
        {
            this.maNhanVien = maNhanVien;
            this.luong = luong;
            this.mucDongGop = luong * 0.2;
        }

        public NhanVien()
        {

        }

    }
}
