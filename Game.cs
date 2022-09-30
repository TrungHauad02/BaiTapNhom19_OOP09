using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoLamTruyenKy;

namespace VoLam_v1._0
{
    internal class Game
    {
        public Game()
        {
            TaoMenu();
        }

        private void TaoMenu()
        {
            int a;
            Console.WriteLine("--- VO LAM TRUYEN KI ---");
            Console.WriteLine("Tao nhan vat:  1");
            Console.WriteLine("Thoat game:    0");
            Console.Write(">>>> ");
            a = int.Parse(Console.ReadLine());
            while(a != 0 && a != 1)
            {
                Console.WriteLine(">>>> ");
                a = int.Parse(Console.ReadLine());
            }
            if(a == 1)
            {
                Console.Clear();
                TaoNhanVat();
            }
            if(a == 0)
            {
                return;
            }
        }

        private void TaoNhanVat()
        {
            string ten;
            int he;
            string tenHe;
            int phai;
            string tenPhai;

            Console.WriteLine("--- VO LAM TRUYEN KI ---");
            Console.WriteLine("Chon mon phai: ");
            Console.WriteLine("Thieu Lam         (He: Kim)  :     0"); 
            Console.WriteLine("Thien Vuong bang  (He: Kim)  :     1");
            Console.WriteLine("Nga My            (He: Thuy) :     2");
            Console.WriteLine("Thuy Yen mon      (He: Thuy) :     3");
            Console.WriteLine("Ngu Doc giao      (He: Moc)  :     4");
            Console.WriteLine("Duong Mon         (He: Moc)  :     5");
            Console.WriteLine("Cai Bang          (He: Hoa)  :     6");
            Console.WriteLine("Thien Nhan giao   (He: Hoa)  :     7");
            Console.WriteLine("Con Lon           (He: Tho)  :     8");
            Console.WriteLine("Vo Dang           (He: Tho)  :     9");


            Console.WriteLine(">>>> ");
            phai = int.Parse(Console.ReadLine());
            while (phai < 0 || phai > 9)
            {
                Console.WriteLine(">>>> ");
                phai = int.Parse(Console.ReadLine());
            }
      
            he = phai == 0 ? 0 //Kim
               : phai == 1 ? 0 
               : phai == 2 ? 1 //Thuy
               : phai == 3 ? 1
               : phai == 4 ? 2 //Moc
               : phai == 5 ? 2
               : phai == 6 ? 3 //Hoa
               : phai == 7 ? 3
               : phai == 8 ? 4 //Tho
               : 4;

            tenHe = phai == 0 ? "Kim"
               : phai == 1 ? "Kim"
               : phai == 2 ? "Thuy"
               : phai == 3 ? "Thuy"
               : phai == 4 ? "Moc" 
               : phai == 5 ? "Moc"
               : phai == 6 ? "Hoa" 
               : phai == 7 ? "Hoa"
               : phai == 8 ? "Tho"
               : "Tho";

            tenPhai = phai == 0 ? "Thieu Lam"
               : phai == 1 ? "Thien Vuong bang"
               : phai == 2 ? "Nga My"
               : phai == 3 ? "Thuy Yen mon"
               : phai == 4 ? "Ngu Doc giao"
               : phai == 5 ? "Duong Mon"
               : phai == 6 ? "Cai Bang"
               : phai == 7 ? "Thien Nhan giao"
               : phai == 8 ? "Con Lon"
               : "Vo Dang";

            phai = (phai % 2) == 0 ? 0
                   : 1;

            Console.WriteLine("Nhap ten nhan vat: ");
            ten = Console.ReadLine();
            NhanVat A = new NhanVat(ten, 1, he, phai);

            Console.Clear();
            Console.WriteLine("--- VO LAM TRUYEN KI ---");
            Console.WriteLine(">> Ban da tao thanh cong nhan vat! <<");
            Console.WriteLine("Ten nhan vat: " + ten);
            Console.WriteLine("He:           " + tenHe);
            Console.WriteLine("Phai:         " + tenPhai);
            Console.WriteLine("Level:        " + 1);
            Console.WriteLine("    <^ ^>");
            Console.WriteLine("   <(   )> ==[]=====>");
            Console.WriteLine("    _| |_ ");

            Console.WriteLine("Nhan phim bat ki de tiep tuc");
            Console.ReadKey();
            Console.Clear();
            //Bat dau vao game
            GamePlay(A);
        }

        private void GamePlay(NhanVat A)
        {
            Console.WriteLine("--- VO LAM TRUYEN KY ---");
        }
    }
}
