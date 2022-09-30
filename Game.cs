using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VoLamTruyenKy;

namespace VoLam_v1._0
{
    
    internal class Game
    {
        NhanVat main;
        private DanhSachNhanVat DSNV;
        private DanhSachQuaiThuong DSQT;
        private DanhSachQuaiThuLinh DSQTL;
        public Game(DanhSachNhanVat DSNV, DanhSachQuaiThuong DSQT, DanhSachQuaiThuLinh DSQTL)
        {
            this.DSNV = DSNV;
            this.DSQT = DSQT;
            this.DSQTL = DSQTL;
            TaoMenu();
        }

        private void TaoMenu()
        {
            string temp;
            int a;
            Console.WriteLine("--- VO LAM TRUYEN KI ---");
            Console.WriteLine("Tao nhan vat:  1");
            Console.WriteLine("Thoat game:    0");
            Console.Write(">>>> ");

            temp = Console.ReadLine();            
            a = kiemTraDauVao(temp,0,1);


            if(a == 1)
            {
                Console.Clear();
                TaoNhanVat();
            }
            if(a == 0)
            {
                Console.WriteLine("Ban da tat game \n Nhan phim bat ky de tiep tuc");
                return;
            }
        }

        private void TaoNhanVat()
        {
            string temp;
            string ten = "";
            int he;
            int phai;

            Console.WriteLine("--- VO LAM TRUYEN KI ---");

            Console.WriteLine("Chon he: ");
            Console.WriteLine("He KIM:     0");
            Console.WriteLine("He THUY:    1");
            Console.WriteLine("He MOC:     2");
            Console.WriteLine("He HOA:     3");
            Console.WriteLine("He THO:     4");
            Console.Write(">>>> ");

            temp = Console.ReadLine();            
            he = kiemTraDauVao(temp,0,4);
            Console.Clear();

            Console.WriteLine("--- VO LAM TRUYEN KI ---");

            Console.WriteLine("Chon mon phai: ");
            switch (he)
            {
                case 0:
                    Console.WriteLine("Thieu Lam:         0");
                    Console.WriteLine("Thien Vuong bang:  1");
                    Console.Write(">>>> ");
                    temp = Console.ReadLine();
                    phai = kiemTraDauVao(temp,0,1);
                    break;
                case 1:
                    Console.WriteLine("Nga My:            0");
                    Console.WriteLine("Thuy Yen mon:      1");
                    Console.Write(">>>> ");
                    temp = Console.ReadLine();
                    phai = kiemTraDauVao(temp, 0, 1);
                    break;
                case 2:
                    Console.WriteLine("Ngu Doc giao:      0");
                    Console.WriteLine("Duong Mon:         1");
                    Console.Write(">>>> ");
                    temp = Console.ReadLine();
                    phai = kiemTraDauVao(temp, 0, 1);
                    break;
                case 3:
                    Console.WriteLine("Cai Bang:          0");
                    Console.WriteLine("Thien Nhan giao:   1");
                    Console.Write(">>>> ");
                    temp = Console.ReadLine();
                    phai = kiemTraDauVao(temp, 0, 1);
                    break;
                default:
                    Console.WriteLine("Con Lon:       0");
                    Console.WriteLine("Vo Dang:       1");
                    Console.Write(">>>> ");
                    temp = Console.ReadLine();
                    phai = kiemTraDauVao(temp, 0, 1);
                    break;
            }
            Console.Clear();

            Console.WriteLine("--- VO LAM TRUYEN KI ---");

            Console.WriteLine("Nhap ten nhan vat: ");
            ten = Console.ReadLine();
            main = new NhanVat(ten, 1, he, phai);
            DSNV.DSNHANVAT.Add(main);

            Console.Clear();
            Console.WriteLine("--- VO LAM TRUYEN KI ---");
            Console.WriteLine(">> Ban da tao thanh cong nhan vat! <<");
            Console.WriteLine("Ten nhan vat: " + ten);
            Console.WriteLine("He:           " + main.He.Hanh);
            Console.WriteLine("Phai:         " + main.He.MonPhai);
            Console.WriteLine("Level:        " + 1);
            Console.WriteLine("    <^ ^>");
            Console.WriteLine("   <(   )> ==[]=====>");
            Console.WriteLine("    _| |_ ");

            troVeMenu();
        }

        public void GamePlay()
        {
            string temp;
            int luaChon;
            Console.WriteLine("--- VO LAM TRUYEN KY ---");
            MenuChinh();
            temp = Console.ReadLine();
            luaChon = kiemTraDauVao(temp, 0, 6);

            switch (luaChon)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    PVP();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    PVE();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    PVB();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    XemDSQuaiThuong();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    XemDSQuaiThuLinh();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    BXHLevel();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("--- VO LAM TRUYEN KY ---");
                    Console.WriteLine("Ban da thoat game!");
                    Console.WriteLine("An phim bat ky de tiep tuc");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }

        private void MenuChinh()
        {
            Console.WriteLine("Vao PvP:       0");
            Console.WriteLine("Vao PvE:       1");
            Console.WriteLine("Danh boss:     2");
            Console.WriteLine("Xem DS Quai:   3");
            Console.WriteLine("Xem DS Boss:   4");
            Console.WriteLine("BXH Level:     5");
            Console.WriteLine("Thoat game:    6");
            Console.Write(">>>> ");
        }

        private int kiemTraDauVao(string temp,int thapNhat, int caoNhat)
        {
            while (!(temp.Length == 1 && temp[0] - '0' >= thapNhat && temp[0] - '0' <= caoNhat))
            {
                Console.Write(">>>> ");
                temp = Console.ReadLine();
            }
            return int.Parse(temp);
        }

        private void troVeMenu()
        {
            Console.WriteLine("An phim bat ky de quay lai menu chinh");
            Console.ReadKey();
            Console.Clear();
            GamePlay();
        }

        private void PVP()
        {
            string temp;
            int luaChon;
            NhanVat nhanVat;
            DSNV.DSNHANVAT.Remove(main);

            // Show DS cho nguoi choi chon nhan vat muon danh
            Console.WriteLine("Chon nhan vat ban muon pvp: ");
            DSNV.xuatDS();
            Console.WriteLine("Quai lai:   0");
            Console.Write(">>>> ");
            temp = Console.ReadLine();
            luaChon = kiemTraDauVao(temp, 0, DSNV.DSNHANVAT.Count);
            if (luaChon == 0)
                troVeMenu();
            nhanVat = DSNV.DSNHANVAT[luaChon - 1];
            DSNV.DSNHANVAT.Add(main);
            Console.WriteLine("Chon nhan vat muon danh thanh cong");
            Console.WriteLine("Nhan phim bat ky de danh");
            Console.ReadKey();
            Console.Clear();

            //Bat dau danh
            double st = NguoiChoi.SatThuong(main, nhanVat);
            if (st == 0)
                Console.WriteLine("Ban khong the gay sat thuong cho doi thu");
            else if (st > 0)
                Console.WriteLine("Ban gay ra " + st + " sat thuong cho doi thu");
            else
                Console.WriteLine("Ban da bi doi thu phan cong lai " + st + " sat thuong");
            troVeMenu();
        }

        private void PVE()
        {
            string temp;
            int luaChon;
            QuaiThuong QV;

            //Show DS va chon quai
            Console.WriteLine("Chon quai thuong ban muon danh: ");
            int n = DSQT.DSQUAITHUONG.Count;
            DSQT.xuatDS();
            Console.WriteLine("Quai lai:   0");
            Console.Write(">>>> ");
            temp = Console.ReadLine();
            luaChon = kiemTraDauVao(temp, 0, n);
            if (luaChon == 0)
                troVeMenu();
            QV = DSQT.DSQUAITHUONG[luaChon - 1];

            Console.WriteLine("Chon quai muon danh thanh cong");
            Console.WriteLine("Nhan phim bat ky de danh");
            Console.ReadKey();
            Console.Clear();

            double st = NguoiChoi.SatThuong(main, QV);
            if (st == 0)
                Console.WriteLine("Ban khong the gay sat thuong cho quai vat thuong");
            else if (st > 0)
                Console.WriteLine("Ban gay ra " + st + " sat thuong cho quai vat thuong");
            else
                Console.WriteLine("Ban da bi quai vat thuong phan cong lai " + st + " sat thuong");
            troVeMenu();
        }

        private void PVB()
        {
            string temp;
            int luaChon;
            QuaiThuLinh Boss;

            //Show DS va chon quai
            Console.WriteLine("Chon quai thuong ban muon danh: ");
            int n = DSQTL.DSQUAITHULINH.Count;
            DSQTL.xuatDS();
            Console.WriteLine("Quai lai:   0");
            Console.Write(">>>> ");
            temp = Console.ReadLine();
            luaChon = kiemTraDauVao(temp, 0, n);
            if (luaChon == 0)
                troVeMenu();
            Boss = DSQTL.DSQUAITHULINH[luaChon - 1];

            Console.WriteLine("Chon boss muon danh thanh cong");
            Console.WriteLine("Nhan phim bat ky de danh");
            Console.ReadKey();
            Console.Clear();

            double st = NguoiChoi.SatThuong(main, Boss);
            if (st == 0)
                Console.WriteLine("Ban khong the gay sat thuong cho boss");
            else if (st > 0)
                Console.WriteLine("Ban gay ra " + st + " sat thuong cho boss");
            else
                Console.WriteLine("Ban da bi boss phan cong lai " + st + " sat thuong");
            troVeMenu();
        }

        private void XemDSQuaiThuong()
        {
            DSQT.SapXepLevel();
            DSQT.xuatDS();
            troVeMenu();
        }

        private void XemDSQuaiThuLinh()
        {
            DSQTL.SapXepLevel();
            DSQTL.xuatDS();
            troVeMenu();
        }

        private void BXHLevel()
        {
            DSNV.SapXepLevel();
            DSNV.xuatDS();
            troVeMenu();
        }

    }
}
