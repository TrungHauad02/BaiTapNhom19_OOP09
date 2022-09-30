using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VoLam_v1._0; // Them gameplay 

namespace VoLamTruyenKy
{
    class Program
    {
        static void Main()
        {
            DanhSachNhanVat NV = new DanhSachNhanVat(5);
            NV.xuatDS();
            NV.STCaoNhat().Xuat();

            DanhSachQuaiThuong QT = new DanhSachQuaiThuong(6);
            QT.xuatDS();
            QT.STCaoNhat().Xuat();

            DanhSachQuaiThuLinh QTL = new DanhSachQuaiThuLinh(7);
            QTL.xuatDS();
            QTL.STCaoNhat().Xuat();

            double st = NguoiChoi.SatThuong(NV.DSNHANVAT[0], QT.DSQUAITHUONG[2]);
            Console.WriteLine(st);

        }
    }
}
