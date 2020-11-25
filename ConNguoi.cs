using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class ConNguoi
    {
        private string hoTen;
        private string tuoi;

        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }

        public string Tuoi
        {
            get
            {
                return tuoi;
            }
            set
            {
                tuoi = value;
            }
        }

        public ConNguoi()
        {
            this.hoTen = "";
            this.tuoi = "";
        }

        public ConNguoi(string hoTen, string tuoi)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
        }

    }
}
