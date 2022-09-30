using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
   
    class DanhSach
    {
        protected Random random = new Random();
        private int sL;
        public int SL { get => sL; set => sL = value; }
        public DanhSach(int SL)
        { 
            this.SL = SL; 
        }

        public virtual void xuatDS()
        {
            return;
        }

        public virtual NguoiChoi STCaoNhat()
        {
            return new NguoiChoi();
        }

        protected virtual void TaoDSNgauNhien()
        {
            return;
        }

        public virtual void SapXepLevel()
        {
            return;
        }
    }
    class DanhSachNhanVat : DanhSach
    {      
        private List<NhanVat> DSNhanVat;

        internal List<NhanVat> DSNHANVAT { get => DSNhanVat; set => DSNhanVat = value; }

        public DanhSachNhanVat(int SL):base(SL)
        {
            
            DSNhanVat = new List<NhanVat>();
            TaoDSNgauNhien();
        }

        protected override void TaoDSNgauNhien()
        {
            string name = "";
            int level;
            int he;
            int monPhai;
            for (int i = 0; i < SL; i++)
            {
                int temp = random.Next(6, 16); //Do dai ten ngau nhien
                for (int j = 0; j < temp; j++)
                    name += Convert.ToString((char)random.Next(97, 122)); //Ten ngau nhien
                level = random.Next(1, 25);
                he = random.Next(0, 4);
                monPhai = random.Next(0, 1);

                DSNhanVat.Add(new NhanVat(name, level, he, monPhai));
                name = "";
            }
        }

        public override void xuatDS()
        {
            int i = 1;
            foreach (NhanVat nv in DSNhanVat)
            {
                Console.WriteLine("Nhan vat " + i++ + ":");
                nv.Xuat();
            }
        }

        public override void SapXepLevel()
        {
            for(int i = 0; i < DSNhanVat.Count; ++i)
            {
                for(int j = i+1; j < DSNhanVat.Count; ++j)
                {   //Sap Xep Level va Ten NV
                    if (DSNhanVat[i].Level < DSNhanVat[j].Level || (DSNhanVat[i].Level == DSNhanVat[j].Level && String.Compare(DSNhanVat[i].Name, DSNhanVat[j].Name, false) > 0))
                    {
                        NhanVat temp = DSNhanVat[i];
                        DSNhanVat[i] = DSNhanVat[j];
                        DSNhanVat[j] = temp;
                    }
                }
            }
            return;
        }

        public override NguoiChoi STCaoNhat()
        {
            SapXepLevel();
            // Bubble sort nguoc :V
            NhanVat result = DSNhanVat[0];
            return result;
        }
    }

    class DanhSachQuai : DanhSach
    {
        public DanhSachQuai(int SL) : base(SL)
        {
        }

    }

    class DanhSachQuaiThuong : DanhSachQuai
    {
        private List<QuaiThuong> DSQuaiThuong;
        internal List<QuaiThuong> DSQUAITHUONG { get => DSQuaiThuong; set => DSQuaiThuong = value; }

        public DanhSachQuaiThuong(int SL) : base(SL)
        {
            DSQuaiThuong = new List<QuaiThuong>();
            TaoDSNgauNhien();
        }

        public override void xuatDS()
        {
            int i = 1;
            foreach (QuaiThuong qv in DSQuaiThuong)
            {
                Console.WriteLine("Quai thuong " + i++ + ":");
                qv.Xuat();
            }
        }

        protected override void TaoDSNgauNhien()
        {
            int level;
            int he;
            for (int i = 0; i < SL; i++)
            {
                level = random.Next(1, 25);
                he = random.Next(0, 4);
                DSQuaiThuong.Add(new QuaiThuong(level, he));
            }
        }
        public override void SapXepLevel()
        {
            for (int i = 0; i < DSQuaiThuong.Count; ++i)
            {
                for (int j = i + 1; j < DSQuaiThuong.Count; ++j)
                {
                    if (DSQuaiThuong[i].Level < DSQuaiThuong[j].Level)
                    {
                        QuaiThuong temp = DSQuaiThuong[i];
                        DSQuaiThuong[i] = DSQuaiThuong[j];
                        DSQuaiThuong[j] = temp;
                    }
                }
            }
            return;
        }
        public override NguoiChoi STCaoNhat()
        {
            SapXepLevel();
            // Bubble sort nguoc :V
            QuaiThuong result = DSQuaiThuong[0];
            return result;
        }
        

        
    }
    class DanhSachQuaiThuLinh : DanhSachQuai
    {
        private List<QuaiThuLinh> DSQuaiThuLinh;

        internal List<QuaiThuLinh> DSQUAITHULINH { get => DSQuaiThuLinh; set => DSQuaiThuLinh = value; }

        public DanhSachQuaiThuLinh(int SL) : base(SL)
        {
            DSQuaiThuLinh = new List<QuaiThuLinh>();
            TaoDSNgauNhien();
        }

        public override void xuatDS()
        {
            int i = 1;
            foreach (QuaiThuLinh qv in DSQuaiThuLinh)
            {
                Console.WriteLine("Quai thu linh: " + i++ + ":");
                qv.Xuat();
            }
        }

        protected override void TaoDSNgauNhien()
        {          
            int level;
            int he;
            for (int i = 0; i < SL; i++)
            {
                level = random.Next(12, 30);
                he = random.Next(0, 4);
                DSQuaiThuLinh.Add(new QuaiThuLinh(level, he));
            }
        }

        public override void SapXepLevel()
        {
            for (int i = 0; i < DSQuaiThuLinh.Count; ++i)
            {
                for (int j = i + 1; j < DSQuaiThuLinh.Count; ++j)
                {
                    if (DSQuaiThuLinh[i].Level < DSQuaiThuLinh[j].Level)
                    {
                        QuaiThuLinh temp = DSQuaiThuLinh[i];
                        DSQuaiThuLinh[i] = DSQuaiThuLinh[j];
                        DSQuaiThuLinh[j] = temp;
                    }
                }
            }
            return;
        }

        public override NguoiChoi STCaoNhat()
        {
            SapXepLevel();
            // Bubble sort nguoc :V
            QuaiThuLinh result = DSQuaiThuLinh[0];
            return result;
        }

    }
}
