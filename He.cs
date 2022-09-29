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
        private string monPhai = ""; // Môn phái chỉ dành cho Nhân vật

        public Hanh Hanh { get => hanh; set => hanh = value; }
        public string MonPhai { get => monPhai; set => monPhai = value; }
        

        public He(Hanh hanh)
        {
            Hanh = hanh;
        }

        ~He()
        {
        }

        public virtual object Sinh()
        {
            return 5;
        }

        public virtual object Khac()
        {
            return 5;
        }
    }

    class Kim : He
    {
        public Kim() : base(Hanh.Kim)
        { 
        }

        public Kim(int monPhai) : base(Hanh.Kim)
        {
            MonPhai = monPhai == 0 ? "Thieu Lam"
                    : "Thien Vuong bang";
        }

        ~Kim()
        {
        }

        public override object Sinh()
        {
            return Hanh.Thuy; // ép kiểu
        }

        public override object Khac()
        {
            return Hanh.Moc;
        }
    }

    class Thuy : He
    {
        public Thuy() : base(Hanh.Thuy)
        { 
        }

        public Thuy(int monPhai) : base(Hanh.Thuy)
        {
            MonPhai = monPhai == 0 ? "Nga My"
                    : "Thuy Yen mon";
        }

        ~Thuy()
        {
        }

        public override object Sinh()
        {
            return Hanh.Moc;
        }
        public override object Khac()
        {
            return Hanh.Hoa;
        }
    }
    class Moc : He
    {
        public Moc() : base(Hanh.Moc)
        { 
        }

        public Moc(int monPhai) : base(Hanh.Moc)
        {
            MonPhai = monPhai == 0 ? "Ngu Doc giao"
                    : "Duong Mon";
        }

        ~Moc()
        {
        }

        public override object Sinh()
        {
            return Hanh.Hoa;
        }
        public override object Khac()
        {
            return Hanh.Tho;
        }
    }

    class Hoa : He
    {
        public Hoa() : base(Hanh.Hoa)
        { 
        }

        public Hoa(int monPhai) : base(Hanh.Hoa)
        {
            MonPhai = monPhai == 0 ? "Cai Bang"
                    : "Thien Nhan giao";
        }

        ~Hoa()
        {
        }

        public override object Sinh()
        {
            return Hanh.Tho;
        }

        public override object Khac()
        {
            return Hanh.Kim;
        }
    }

    class Tho : He
    {
        public Tho() : base(Hanh.Tho)
        { 
        }

        public Tho(int monPhai) : base(Hanh.Tho)
        {
            MonPhai = monPhai == 0 ? "Con Lon"
                    : "Vo Dang";
        }

        ~Tho()
        {
        }

        public override object Sinh()
        {
            return Hanh.Kim;
        }

        public override object Khac()
        {
            return Hanh.Thuy;
        }
    }
}
