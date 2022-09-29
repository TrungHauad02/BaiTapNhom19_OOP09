using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    internal class NguoiChoi
    {
        private int level;
        private He he;

        public int Level { get => level; set => level = value; }
        internal He He { get => he; set => he = value; }

        public virtual int Atk()
        {
            return 0; 
        }
        
        public NguoiChoi()
        { }

        ~NguoiChoi()
        { }

        public static int SatThuong(NguoiChoi A, NguoiChoi B)
        {
            if (A.He.Sinh())
        }
    }

    class NhanVat : NguoiChoi
    {
        private string monPhai;

        public string MonPhai { get => monPhai; }

        public override int Atk()
        {
            return Level * 5;
        }

        public NhanVat(string monPhai, int level, He he)
        {
            this.monPhai = monPhai;
            Level = level;
        }
    }

    class QuaiVat : NguoiChoi
    {
        public QuaiVat()
        { }

        ~QuaiVat()
        { }

    }

    class QuaiThuong : QuaiVat
    {
        public override int Atk()
        {
            return Level * 3;
        }

        public QuaiThuong(int level)
        {
            Level = level;
        }

        ~QuaiThuong()
        { }
    }

    class QuaiThuLinh : QuaiVat
    {
        public override int Atk()
        {
            return Level * 7;
        }

        public QuaiThuLinh(int level)
        {
            Level = level;
        }

        ~QuaiThuLinh()
        { }
    }
}
