using System;

namespace AsiaPark
{
    class KhachHang
    {
        protected string ten;
        protected double giaVe;

        public KhachHang(string ten, double giaVe)
        {
            this.ten = ten;
            this.giaVe = giaVe;
        }

        public virtual void MuaVe()
        {
            Console.WriteLine("Đã mua vé thành công cho {0} với giá {1} đồng.", ten, giaVe);
        }

        public virtual void DeoThe()
        {
            Console.WriteLine("Thẻ của {0} là thẻ trắng.", ten);
        }
    }

    class NguoiLon : KhachHang
    {
        private string cmnd;

        public NguoiLon(string ten, string cmnd) : base(ten, 250000)
        {
            this.cmnd = cmnd;
        }

        public override void MuaVe()
        {
            base.MuaVe();
            Console.WriteLine("Đã mua vé thành công cho người lớn {0} với giá {1} đồng.", ten, giaVe);
        }

        public override void DeoThe()
        {
            Console.WriteLine("Thẻ của người lớn {0} là thẻ đỏ.", ten);
        }
    }

    class TreEm : KhachHang
    {
        private double chieuCao;

        public TreEm(string ten, double chieuCao) : base(ten, chieuCao > 100 ? 130000 : 0)
        {
            this.chieuCao = chieuCao;
        }

        public override void MuaVe()
        {
            if (giaVe > 0)
            {
                base.MuaVe();
                Console.WriteLine("Đã mua vé thành công cho trẻ em {0} với giá {1} đồng.", ten, giaVe);
            }
            else
            {
                Console.WriteLine("Trẻ em {0} được miễn phí vé.", ten);
            }
        }

        public override void DeoThe()
        {
            Console.WriteLine("Thẻ của trẻ em {0} là thẻ xanh.", ten);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int soNguoiLon, soTreEm;
            double doanhThu = 0;

            Console.Write("Nhập số người lớn: ");
            soNguoiLon = int.Parse(Console.ReadLine());

            Console.Write("Nhập số trẻ em: ");
            soTreEm = int.Parse(Console.ReadLine());

            KhachHang[] khachHangs = new KhachHang[soNguoiLon + soTreEm];

            for (int i = 0; i < soNguoiLon; i++)
            {
                Console.WriteLine("Nhập thông tin người lớn thứ {0}:", i + 1);
                Console.Write("Tên khách hàng: ");
                string ten = Console.ReadLine();
                Console.Write("CMND: ");
                string cmnd = Console.ReadLine();

                khachHangs[i] = new NguoiLon(ten, cmnd);
            }

            for (int i = soNguoiLon; i < soNguoiLon + soTreEm; i++)
            {
                Console.WriteLine("Nhập thông tin trẻ em thứ {0}:", i - soNguoiLon + 1);
                Console.Write("Tên khách hàng: ");
                string ten = Console.ReadLine();
                Console.Write("Chiều cao (cm): ");
                double chieuCao = double.Parse(Console.ReadLine());

                khachHangs[i] = new TreEm(ten, chieuCao);
            }

            foreach (KhachHang khachHang in khachHangs)
            {
                khachHang.MuaVe();
                khachHang.DeoThe();
                doanhThu += khachHang.giaVe;
            }

            Console.WriteLine("Doanh thu của công viên Asia Park sau một lượt tham quan là {0} đồng.", doanhThu);
        }
    }
}
