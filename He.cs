using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    enum Hanh
    {
        // Thứ tự của ngũ hành được quy định theo đề bài
        Kim,    // 0
        Thuy,   // 1
        Moc,    // 2
        Hoa,    // 3
        Tho     // 4
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
            return (int)Hanh.Thuy; // ép kiểu
        }

        public override int Khac()
        {
            return (int)Hanh.Moc;
        }
    }

    class Thuy : He
    {
        public Thuy() : base(Hanh.Thuy)
        {
        }

        public override int Sinh()
        {
            return (int)Hanh.Moc;
        }
        public override int Khac()
        {
            return (int)Hanh.Hoa;
        }
    }
    class Moc : He
    {
        public Moc() : base(Hanh.Moc)
        {
        }

        public override int Sinh()
        {
            return (int)Hanh.Hoa;
        }
        public override int Khac()
        {
            return (int)Hanh.Tho;
        }
    }

    class Hoa : He
    {
        public Hoa() : base(Hanh.Hoa)
        {
        }

        public override int Sinh()
        {
            return (int)Hanh.Tho;
        }

        public override int Khac()
        {
            return (int)Hanh.Kim;
        }
    }

    class Tho : He
    {
        public Tho() : base(Hanh.Tho)
        {
        }

        public override int Sinh()
        {
            return (int)Hanh.Kim;
        }

        public override int Khac()
        {
            return (int)Hanh.Thuy;
        }
    }
}
