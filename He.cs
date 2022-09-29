using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    enum Hanh
    {
        Kim,
        Moc,
        Thuy,
        Hoa,
        Tho
    }
    class He
    {
        private Hanh hanh;

        public He(Hanh hanh)
        {
            this.hanh = hanh;
        }

        //public bool Sinh(He A)
        //{
        //    int temp = (int)hanh + 1;
        //    if (temp > 4)
        //        temp = 0;
        //    if (temp == ().dinhDanh)
        //        return true;
        //    return false;
        //}

        public virtual int Sinh()
        {
            return 5;
        }

        //public bool Khac(He A)
        //{
        //    int temp = (int)hanh + 2;
        //    if (temp > 4)
        //        temp = 1;
        //    if (temp == A.dinhDanh)
        //        return true;
        //    return false;
        //}

        public virtual int Khac()
        {
            return 5;
        }
    }

    class Kim : He
    {
        public Kim() : base(Hanh.Kim)
        {
        }

        public override int Sinh()
        {
            return 1;
        }

        public override int Khac()
        {
            return 2;
        }
    }

    class Moc : He
    {
        public Moc() : base(Hanh.Moc)
        {
        }

        public override int Sinh()
        {
            return 3;
        }
        public override int Khac()
        {
            return 4;
        }
    }

    class Thuy : He
    {
        public Thuy() : base(Hanh.Thuy)
        {
        }

        public override int Sinh()
        {
            return 2;
        }
        public override int Khac()
        {
            return 3;
        }
    }

    class Hoa : He
    {
        public Hoa() : base(Hanh.Hoa)
        {
        }

        public override int Sinh()
        {
            return 4;
        }

        public override int Khac()
        {
            return 0;
        }
    }

    class Tho : He
    {
        public Tho() : base(Hanh.Tho)
        {
        }

        public override int Sinh()
        {
            return 0;
        }

        public override int Khac()
        {
            return 1;
        }
    }
}
