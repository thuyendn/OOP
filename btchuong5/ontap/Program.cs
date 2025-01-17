
// // KHÔNG CÓ NHẬP DANH SÁCH--THI 
// // using System;
// // namespace C5Vd4
// // {
// //     class XeHoi
// //     {
// //         protected int TocDo;
// //         protected string BienSo;
// //         protected string HangSX;
// //         public XeHoi(int td, string BS,string HSX)
// //         {
// //             TocDo = td; BienSo = BS; HangSX = HSX;
// //         }
// //         public void Xuat()
// //         {
// //             Console.Write("Xe: {0}, Bien so: {1}, Tocdo: {2} kmh", HangSX, BienSo, TocDo);
// //         }
// //     }
// //     class XeCar: XeHoi
// //     {
// //         int SoHanhKhach;
// //         public XeCar(int td, string BS, string HSX, int SHK):
// //         base(td,BS,HSX)
// //         {
// //             SoHanhKhach = SHK;
// //         }
// //         public new void Xuat()
// //         {
// //             base.Xuat();
// //             Console.WriteLine(",{0} cho ngoi", SoHanhKhach);
// //         }
// //     }
// //     class XeTai: XeHoi
// //     {
// //         int TrongTai;
// //         public XeTai(int td, string BS, string HSX, int TT):
// //         base(td,BS,HSX)
// //         {
// //             TrongTai = TT;
// //         }
// //         public new void Xuat()
// //         {
// //             base.Xuat();
// //             Console.WriteLine(", trong tai {0} tan", TrongTai);
// //         }
// //     }
// //     public class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             XeCar c = new XeCar(150,"43A-45235","Toyota", 24);
// //             c.Xuat();
// //             XeTai t = new XeTai(150,"43A-98235","Benz",12);
// //             t.Xuat();
// //         }
// //     }
// // }


// // bài cuối cùng chương 6, dễ ra thi 


// // BẢI TẬP ÔN TẬP CHƯƠNG KẾ THỪA, ĐA HÌNH
// // Bài 1. Công viên Asia Park bán vé vui chơi với giá vé trọn gói là 250.000đ/ người lớn.
// // 130.000đ/ trẻ em trên 1m, và miễn phí cho trẻ em dưới Im. Khách đến chơi gồm có người lớn và trẻ em.
// // Viết chương trình quản lý thông tin mua vé, gồm các thông tin:
// // Đối với khách hàng là người lớn: Tên khách hàng, CMND. Giá vé.
// // Đối với khách hàng là trẻ em: Tên khách hàng, chiều cao. Giá vé.
// // Sau khi mua vé thì khách hàng sẽ được đeo thẻ như sau: Người lớn sẽ mang thẻ đỏ, trẻ em sẽ được mang thể xanh.
// // Tỉnh doanh thu của công viên sau một lượt tham quan.

// using System;
// class KH
//     {
//         public string Ten;
//         public string Giave;
//         public KH(string ten, string giave)
//         {
//             Ten=ten;
//             Giave=giave;
//         }
//         public void MuaVe()
//             {Console.WriteLine("Đã mua vé thành công cho {0} với giá {1} đồng.", ten, giave); }
//     }
// class Nguoilon: KH
//     {
//         private string Cmnd;
//         public Nguoilon(string ten,string cmnd): base(ten,250000)
//         {
//             Cmnd=cmnd;
//         }
//         public void muave()
//         {
//             base.muave();
//             Console.WriteLine("Đã mua vé thành công cho người lớn {0} với giá {1} đồng.", ten, giave);
//         }
//         public void DeoThe()
//         {
//             Console.WriteLine("Thẻ của người lớn {0} là thẻ đỏ.", ten);
//         }

//     }
//  class Treem : KH
//     {
//         private double chieucao;

//         public Treem(string ten, double chieucao) : base(ten, chieuCao > 100 ? 130000 : 0)
//         {
//             this.chieuCao = chieuCao;
//         }
//     }

//     int age = 20;
// string message = (age >= 18) ? "You are an adult" : "You are not an adult";




// using System;
// class KhachHang
//     {
//         protected string ten;
//         protected double giaVe;

//         public KhachHang(string ten, double giaVe)
//         {
//             this.ten = ten;
//             this.giaVe = giaVe;
//         }
//          public double LayGiaVe()  // Thêm phương thức để lấy giá vé
//     {
//         return giaVe;
//     }
//         public virtual void MuaVe()
//         {
//             Console.WriteLine("Đã mua vé thành công cho {0} với giá {1} đồng.", ten, giaVe);
//         }

//         public virtual void DeoThe()
//         {
//             Console.WriteLine("Thẻ của {0} là thẻ trắng.", ten);
//         }
//     }

//     class NguoiLon : KhachHang
//     {
//         private string cmnd;

//         public NguoiLon(string ten, string cmnd) : base(ten, 250000)
//         {
//             this.cmnd = cmnd;
//         }

//         public override void MuaVe()
//         {
//             base.MuaVe();
//             Console.WriteLine("Đã mua vé thành công cho người lớn {0} với giá {1} đồng.", ten, giaVe);
//         }

//         public override void DeoThe()
//         {
//             Console.WriteLine("Thẻ của người lớn {0} là thẻ đỏ.", ten);
//         }
//     }

//     class TreEm : KhachHang
//     {
//         private double chieuCao;

//         public TreEm(string ten, double chieuCao) : base(ten, chieuCao > 100 ? 130000 : 0)
//         {
//             this.chieuCao = chieuCao;
//         }

//         public override void MuaVe()
//         {
//             if (giaVe > 0)
//             {
//                 base.MuaVe();
//                 Console.WriteLine("Đã mua vé thành công cho trẻ em {0} với giá {1} đồng.", ten, giaVe);
//             }
//             else
//             {
//                 Console.WriteLine("Trẻ em {0} được miễn phí vé.", ten);
//             }
//         }

//         public override void DeoThe()
//         {
//             Console.WriteLine("Thẻ của trẻ em {0} là thẻ xanh.", ten);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int soNguoiLon, soTreEm;
//             double doanhThu = 0;

//             Console.Write("Nhập số người lớn: ");
//             soNguoiLon = int.Parse(Console.ReadLine());

//             Console.Write("Nhập số trẻ em: ");
//             soTreEm = int.Parse(Console.ReadLine());

//             KhachHang[] khachHangs = new KhachHang[soNguoiLon + soTreEm];

//             for (int i = 0; i < soNguoiLon; i++)
//             {
//                 Console.WriteLine("Nhập thông tin người lớn thứ {0}:", i + 1);
//                 Console.Write("Tên khách hàng: ");
//                 string ten = Console.ReadLine();
//                 Console.Write("CMND: ");
//                 string cmnd = Console.ReadLine();

//                 khachHangs[i] = new NguoiLon(ten, cmnd);
//             }

//             for (int i = soNguoiLon; i < soNguoiLon + soTreEm; i++)
//             {
//                 Console.WriteLine("Nhập thông tin trẻ em thứ {0}:", i - soNguoiLon + 1);
//                 Console.Write("Tên khách hàng: ");
//                 string ten = Console.ReadLine();
//                 Console.Write("Chiều cao (cm): ");
//                 double chieuCao = double.Parse(Console.ReadLine());

//                 khachHangs[i] = new TreEm(ten, chieuCao);
//             }

//             foreach (KhachHang khachHang in khachHangs)
//             {
//                 khachHang.MuaVe();
//                 khachHang.DeoThe();
//                 doanhThu += khachHang.LayGiaVe();

//                 Console.WriteLine("Doanh thu của công viên Asia Park sau một lượt tham quan là {0} đồng.", doanhThu);
//             }
//         }
//     }






using System;

class KhachHang
{
    public string ten;
    public double giaVe;

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
            doanhThu += khachHang.giaVe;  // Giữ nguyên cách truy cập
        }

        Console.WriteLine("Doanh thu của công viên Asia Park sau một lượt tham quan là {0} đồng.", doanhThu);
    }
}
