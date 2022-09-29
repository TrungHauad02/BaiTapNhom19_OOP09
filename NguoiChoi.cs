using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    class NguoiChoi
    {
        private int level;
        private He he;

        public int Level { get => level; set => level = value; }
        internal He He { get => he; set => he = value; }

        public NguoiChoi(int level, int he)
        {
            Level = level;
            He = he == 0 ? new Kim()
               : he == 1 ? new Thuy()
               : he == 2 ? new Moc()
               : he == 3 ? new Hoa()
               : new Tho();
        }

        public NguoiChoi(int level, int he, int monPhai)
        {
            // Constructor cho NhanVat
            Level = level;
            He = he == 0 ? new Kim(monPhai)
               : he == 1 ? new Thuy(monPhai)
               : he == 2 ? new Moc(monPhai)
               : he == 3 ? new Hoa(monPhai)
               : new Tho(monPhai);
        }

        ~NguoiChoi()
        { 
        }

        public virtual int Atk()
        {
            return 0;
        }

        public static double SatThuong(NguoiChoi A, NguoiChoi B)
        {
            if (A.He.Sinh().Equals(B.He.Hanh))
            {
                return (double)A.Atk() * 110 / 100 - B.Atk();
            }

            if (A.He.Khac().Equals(B.He.Hanh))
            {
                return (double)A.Atk() * 120 / 100 - B.Atk();
            }

            if (A.He.Hanh.Equals(B.He.Khac()))
            {
                return (double)A.Atk() * 80 / 100 - B.Atk();
            }

            else return A.Atk() - B.Atk();
        }
    }

    class NhanVat : NguoiChoi
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public NhanVat(string name, int level, int he, int monPhai) : base(level, he, monPhai)
        {
            this.name = name;
        }

        ~NhanVat()
        {
        }

        public override int Atk()
        {
            return Level * 5;
        }
    }

    class QuaiVat : NguoiChoi
    {
        public QuaiVat(int level, int he) : base(level, he)
        {
        }

        ~QuaiVat()
        { 
        }

    }

    class QuaiThuong : QuaiVat
    {
        public QuaiThuong(int level, int he) : base(level, he)
        {
        }

        ~QuaiThuong()
        { 
        }

        public override int Atk()
        {
            return Level * 3;
        }
    }

    class QuaiThuLinh : QuaiVat
    {
        public QuaiThuLinh(int level, int he) : base(level, he)
        {
        }

        ~QuaiThuLinh()
        { 
        }

        public override int Atk()
        {
            return Level * 7;
        }
    }
}
