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
            NhanVat a1 = new("Vo Dang", 5);
            Console.WriteLine(a1.Atk());
        }
    }
}
