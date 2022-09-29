using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    class Program
    {
        static void Main()
        {
            NguoiChoi a1 = new NhanVat("Test000", 15, 0, 1); // cấp 15 hệ Kim phái Thiếu Lâm
            NguoiChoi a2 = new NhanVat("Test001", 10, 4, 1);
            Console.WriteLine(a1.He.MonPhai);
            Console.WriteLine(NguoiChoi.SatThuong(a1, a2));
        }
    }
}
