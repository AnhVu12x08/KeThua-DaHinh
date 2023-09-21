using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_DaHinh
{
    public class ChuyenXe
    {
        protected string maSo;
        protected string hoTen;
        protected int soXe;
        protected double doanhThu;

        public ChuyenXe()
        {
            maSo = string.Empty;
            hoTen = string.Empty;
            soXe = 0;
            doanhThu = 0;
        }
        public ChuyenXe(string maSo, string hoTen, int soXe, double doanhThu)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.soXe = soXe;
            this.doanhThu = doanhThu;
        }
        //public string MaSo
        //{
        //    get { return maSo; }
        //    set { maSo = value; }
        //}
        public virtual void nhap()
        {
            Console.WriteLine("nhap vao ma so xe, ho ten, so xe, doanh thu");
            maSo = Console.ReadLine();
            hoTen = Console.ReadLine();
            soXe = int.Parse(Console.ReadLine());
            doanhThu = double.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("ma so: {0} \nho ten: {1} \nso xe: {2} \ndoanh thu: {3}",maSo,hoTen,soXe,doanhThu);
        }

    }
}
