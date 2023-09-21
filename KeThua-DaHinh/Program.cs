using KeThua_DaHinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua_DaHinh
{
    class program
    {
        static void Main(string[] args)
        {
            ChuyenXe xe1 = new ChuyenXe();
            xe1.nhap();
            xe1.xuat();
            CXNT xe2 = new CXNT();
            xe2.nhap();
            xe2.xuat();
            CXNgT xe3 = new CXNgT();
            xe3.nhap();
            xe3.xuat();
        }
    }
}