using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class CXNgT : ChuyenXe
    {
        private String noiDen;
        private double soNgayDiDuoc;
        public CXNgT() : base()
        {
            noiDen = string.Empty;
            soNgayDiDuoc = 0;
        }
        public CXNgT(string maSo, string hoTen, int soXe, double doanhThu, string noiDen, double soNgayDiDuoc) : base(maSo, hoTen, soXe, doanhThu)
        {
            this.noiDen = string.Empty;
            this.soNgayDiDuoc = 0;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("noi den");
            Console.WriteLine("so ngay di duoc");
            noiDen = Console.ReadLine();
            soNgayDiDuoc = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("noi den: {0} \nso ngay di duoc: {1}",noiDen, soNgayDiDuoc);
        }
    }
}
