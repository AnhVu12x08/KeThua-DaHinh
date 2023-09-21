using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    internal class CXNT : ChuyenXe
    {
        private double soTuyen;
        private double soKm;
        public CXNT() : base()
        {
            soTuyen = 0;
            soKm = 0;
        }
        public CXNT(string maSo, string hoTen, int soXe, double doanhThu, double soTuyen, double soKm) : base(maSo, hoTen, soXe, doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soKm = soKm;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("so tuyen");
            Console.WriteLine("so km");
            soTuyen = double.Parse(Console.ReadLine());
            soKm = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so tuyen: {0} \nso km: {1}",soTuyen, soKm);
        }
    }
}
