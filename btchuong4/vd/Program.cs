// // // // using System;
// // // // class hinhchunhat
// // // // {
// // // //     public double dai{get;set;}
// // // //     public double rong{get;set;}
// // // //     public double tinhdientich()
// // // //     {
// // // //         return dai*rong;
// // // //     }
// // // //     public void xuat()
// // // //     {
// // // //         Console.WriteLine("dien tich: {0}", tinhdientich());
// // // //     }
// // // // }
// // // // class Program
// // // // {
// // // //     static void Main(string[] args)
// // // //     {
// // // //         hinhchunhat hcn=new hinhchunhat();
// // // //         hcn.dai=4.5;
// // // //         hcn.rong=3.5;
// // // //         hcn.xuat();
// // // //         Console.ReadLine();
// // // //     }
// // // // }




// // // using System;
// // // namespace C4vd2
// // // {
// // //     class hinhchunhat
// // //     {
// // //         private double cdai;
// // //         private double crong;
// // //         public hinhchunhat(double dai, double rong)
// // //         {
// // //             cdai=dai;
// // //             crong=rong;
// // //         }
// // //         public double tinhdientich()
// // //         {
// // //             return cdai*crong;
// // //         }
// // //         public void xuat()
// // //         {
// // //             Console.WriteLine("chieu dai: {0}",cdai);
// // //             Console.WriteLine("chieu rong:{0}",crong);
// // //             Console.WriteLine("dien tich: {0}", tinhdientich());
// // //         }     
// // //     }
// // //     class Program
// // //     {
// // //         static void Main()
// // //         {
// // //             hinhchunhat hcn= new hinhchunhat(5.5,3.5);
// // //             hcn.xuat();

// // //         }
// // //     }
// // // }

// // // // class hcnTester
// // // // {
// // // //     static void Main()
// // // //     {
// // // //     Shape shape = new Shape();
// // // //     shape.SetRong(4);
// // // //     shape.SetDai(6);
// // // //     shape.Xuat();
// // // //     }
// // // // }
// // // // class hcn: Shape
// // // // {
// // // //     public int tinhdientich()
// // // //     {
// // // //         return crong*cdai;
// // // //     }
// // // // }
// // // // class hcnTester
// // // // {
// // // //     static void Main(string[] args)
// // // //     {
// // // //         hcn hcn = new hcn();
// // // //         hcn.SetRong(5);
// // // //         hcn.SetDai(7);
// // // //         hcn.Xuat();
// // // //         Console.WriteLine("Total area: {0}", hcn. TinhDientich());
// // // //         Console.ReadKey();
// // // //     }
// // // // }







// // // // namespace C4Vd3 {
// // // //     public class HinhChuNhat
// // // //     {
// // // //         internal double Dai;
// // // //         internal double Rong;
// // // //         double TinhDientich() // private method
// // // //         {
// // // //             return Dai * Rong;
// // // //         }
// // // //         public void Xuat()
// // // //         {
// // // //         Console.WriteLine("Dai: {0}", Dai);
// // // //         Console.WriteLine("Rong: {0}", Rong);
// // // //         Console.WriteLine("Dien tich: {0}", TinhDientich());
// // // //         }
// // // //     }
// // // //     class Program
// // // //     {
// // // //         static void Main(string[] args)
// // // //         {
// // // //             HinhChuNhat hcn = new HinhChuNhat();
// // // //             hcn.Dai = 4.5;
// // // //             hcn.Rong = 3.5;
// // // //             hcn.Xuat();
// // // //             Console.ReadLine();
// // // //         }
// // // //     }
// // // // }









// // // // using System;
// // // // class sinhvien
// // // // {
// // // //     private string masv;
// // // //     private double diem;
// // // //     public string getmasv()
// // // //     {
// // // //         return masv;
// // // //     }
// // // //     public void setdiem(int diemcslt)
// // // //     {
// // // //         Diemcslt=diemcslt;
// // // //     }
// // // // }
// // // // class sinhvien
// // // // {
// // // //     public void showinfo()
// // // //     {
// // // //         masv="1234";
// // // //         Console.WriteLine("sv ma so {0} co diem la:{1}",masv,Diemcslt);
// // // //     }
// // // // }
// // // // class diemhp
// // // // {
// // // //     static void Main()
// // // //     {
// // // //         sinhvien sv=new sinhvien();
// // // //         sv.getmasv();
// // // //         sv.setDiemcslt(8);
// // // //         sv.showinfo();
// // // //     }
// // // // }





// // // // class Sinhvien
// // // // {
// // // //     private string MASV;
// // // //     private double DiemCSLT;
// // // //     public double diemcslt
// // // //     {
// // // //         get {return DiemCSLT;}
// // // //         set {DiemCSLT=value;}
// // // //     }
// // // //     public string masv
// // // //     {
// // // //         get {return MASV;}
// // // //         set {MASV=value;}
// // // //     }
// // // // }
// // // // class DiemHP
// // // // {
// // // //     static void Main(string[] args)
// // // //     {
// // // //         Sinhvien SV1=new Sinhvien();
// // // //         SV1.masv="5678";
// // // //         SV1.diemcslt=9;
// // // //         Console.WriteLine("SV ma so {0} co diem la: {1}",SV1.masv,SV1.diemcslt);
// // // //     }
// // // // }



// // // // class Hocsinh
// // // // {
// // // //     private string ten;
// // // //     public string TEN
// // // //     {
// // // //         get {return ten;}
// // // //         set { ten=value;}
// // // //     }
// // // //     public static int count=0;
// // // //     public Hocsinh()
// // // //     {
// // // //         Console.Write("nhap ho ten hoc sinh:");
// // // //         ten=Console.ReadLine();
// // // //         count++;
// // // //     }
// // // // }
// // // // class SodoHocsinh
// // // // {
// // // //     static void Main()
// // // //     {
// // // //         Console.WriteLine("so luong hoc sinh ban dau:",+Hocsinh.count);
// // // //         Hocsinh hs1= new Hocsinh();
// // // //         Console.WriteLine("So luong hoc sinh ban dau: "+Hocsinh.count);
// // // //         Hocsinh hs2 = new Hocsinh();
// // // //         Console.WriteLine("So luong hoc sinh ban dau: "+Hocsinh.count);
// // // //     }
// // // // }




// // // //tính lũy thừa của một số nguyên
// // // class Tinhtoan
// // //     {
// // //         public static long LuyThua(int CoSo, int SoMu)
// // //         {
// // //             long KetQua = 1;
// // //             for (int i = 0; i < SoMu; i++)
// // //             {
// // //                 KetQua *= CoSo;
// // //             }
// // //             return KetQua;
// // //         }
// // // }

// // // class Program
// // // {
// // //     static void Main(string[] args)
// // //     {
// // //     Console.WriteLine(Tinhtoan.LuyThua(3, 3));
// // //     }
// // // }


// // // using System;
// // // class hinhchunhat
// // // {
// // //     public double dai;
// // //     public double rong;
// // //     public double dientich()
// // //     {
// // //         return dai*rong;
// // //     }
// // //     public void xuat()
// // //     {
// // //         Console.WriteLine("chieu dai hinh chu nhat: {0}",dai);
// // //         Console.WriteLine("chieu rong hinh chu nhat: {0}",rong);
// // //         Console.WriteLine("dientich: {0}",dientich());
// // //     }
// // // }
// // // class Program
// // // {
// // //     static void Main(string[] args)
// // //     {
// // //         hinhchunhat hcn=new hinhchunhat();
// // //         hcn.dai=4;
// // //         hcn.rong=5;
// // //         hcn.xuat();
// // //     }
// // // }





// // using System;
// // class hinhchunhat
// // {
// //     private double daii;
// //     private double rongg;
// //     public hinhchunhat(double dai, double rong)
// //     {
// //         daii=dai;
// //         rongg=rong;
// //     }
// //     public double dientich()
// //     {
// //         return daii*rongg;
// //     }

// //     public void xuat()
// //     { Console.WriteLine("chieu dai hinh chu nhat: {0}",daii);
// //         Console.WriteLine("chieu rong hinh chu nhat: {0}",rongg);
// //        Console.WriteLine("dientich: {0}",dientich());

// //     }
// // }
// // class program
// // {
// //     static void Main()
// //     {
// //         hinhchunhat hcn=new hinhchunhat(4.4,5.5);
// //         hcn.xuat();
// //     }
// // }

// class People
// {
//     int old; string name; double height;
//     public People(string name, int old, double height)
//     {
//     this.name = name;
//     this.old = old;
//     this.height = height;
//     }
//     public void Show()
//     {
//     Console.WriteLine("Name: " + name + "\nOld: " + old + "\nHeight: " + height);
//     }
// }
// class Program
//     {
//     static void Main(string[] args)
//     {
//     People p1 = new People("Nguyen Van A",20,180);
//     p1.Show();
//     }
// }
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Runtime.Versioning;
using System.Collections.Generic;
using System.Reflection.Metadata;
namespace BANHANG
{
    class Shop
    {
        // MaSP (mã sản phẩm), TenSP (tên sản phẩm), Tonkho (Tồn kho), Phanloai (Phân loại), Giaban (Giá bán)
        private string MaSP, TenSP, Phanloai;
        private int Tonkho, Giaban;
        public string maSP {get {return MaSP;}set{ MaSP=value;}}
        public string tenSP {get {return TenSP;}set{ TenSP=value;}}
        public int tonkho {get {return Tonkho;}set{ Tonkho=value;}}
        public string phanloai {get {return Phanloai;}set{ Phanloai=value;}}
        public int giaban {get {return Giaban;}set{ Giaban=value;}}
    }
    class QuanLyShop
    {
        public List<Shop> shop = new List<Shop>();
        public void nhapDS()
        {
            string input=File.ReadAllText(@"shop.txt");
            foreach (var row in input.Split("\n"))
            {
                string [] res = new string[5]; 
                int j=0;
                foreach (var col in row.Trim().Split(";"))
                {
                    res[j]=col.Trim();
                    j++;
                }
                Shop sp = new Shop();
                sp.maSP = res[0];
                sp.tenSP= res[1];
                sp.tonkho=Convert.ToInt32(res[2]);
                sp.phanloai= res[3];
                sp.giaban=Convert.ToInt32(res[4]);
                shop.Add(sp);
            }
        }
        public void xuatDS()
        {
            foreach (var ds in shop)
            {
                Console.WriteLine($"{ds.maSP} ; {ds.tenSP} ; {ds.tonkho} ; {ds.phanloai} ; {ds.giaban} ");
            }
        }
        public void cap_nhat()
        {
            Console.Write("Nhap ma san pham can cap nhat thong tin: ");
            string ma=Console.ReadLine();
            int t=0;
            foreach (var ds in shop)
            {
                if (ds.maSP==ma) 
                {
                    t=1;
                    Console.Write("So luong: ");
                    int sl =Convert.ToInt32(Console.ReadLine());
                    ds.tonkho=sl;
                    Console.Write("Gia ban: ");
                    int gb =Convert.ToInt32(Console.ReadLine());
                    ds.giaban=gb;
                    break;
                }
            }
            if (t==0) {Console.WriteLine("Khong tim thay ma san pham");}
            else {xuatDS();}
        }
        public void thong_ke()
        {
            foreach (var ds in shop)
            {
                if (ds.tonkho<=10) 
                {
                    Console.WriteLine($"{ds.maSP} ; {ds.tenSP} ; {ds.tonkho} ; {ds.phanloai} ; {ds.giaban} ");
                }
            }
        }
        public void mua_hang()
        {
            Console.WriteLine("Nhap thong tin san pham can mua");
            int j=0,t=0,s=0,t1=0;
            while (true)
            {
                t=0;
                Console.Write("Ma san pham: ");
                string ma =Console.ReadLine();
                foreach (var ds in shop)
                {
                    if (ds.maSP==ma)
                    {
                        t=1;
                        Console.Write("So luong: ");
                        int sl =Convert.ToInt32(Console.ReadLine());
                        if (ds.tonkho<sl) {Console.WriteLine("Không hợp lệ");break;}
                        else {s+=sl*ds.giaban;ds.tonkho-=sl;}
                    }
                }
                if (t==0) {Console.WriteLine("Không hợp lệ");}
                if (t==1)
                {
                    Console.WriteLine("Nhan 1 de mua them; nhan 0 de ket thuc");
                    t1=Convert.ToInt32(Console.ReadLine());
                    if (t1==0) {Console.WriteLine($"Số tiền cần phải trả cho hóa đơn là {s}");break;}
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.Unicode;
            Console.OutputEncoding=Encoding.Unicode;
            QuanLyShop quanly = new QuanLyShop();
            quanly.nhapDS();
            while (true)
            {
                Console.WriteLine("------MENU------\nChon so theo yeu cau");
                Console.WriteLine("#1. CAP NHAT (so luong, gia ban)");
                Console.WriteLine("#2. THONG KE (san pham co ton kho<=10)");
                Console.WriteLine("#3. MUA HANG (dua tren ma san pham và so luong)");
                Console.WriteLine("#0. EXIT");
                Console.Write("Vui long chon yeu cau:");
                int number = Convert.ToInt16(Console.ReadLine());
                if (number==1)
                {
                    Console.WriteLine("--CAP NHAT THONG TIN SAN PHAM--");
                    quanly.cap_nhat();
                }
                else if (number==2)
                {
                    Console.WriteLine("--THONG KE SAN PHAM--");
                    quanly.thong_ke();
                }
                else if (number==3)
                {
                    Console.WriteLine("--MUA HANG--");
                    quanly.mua_hang();
                }
                else if (number==0)
                {
                    Console.WriteLine("---KET THUC CHUONG TRINH---");
                    break;
                }
            }
        }
    }
}



// Xây dựng lớp Shop (Cửa hàng) gồm các thuộc tính: MaSP (mã sản phẩm), TenSP (tên sản phẩm), Tonkho (Tồn kho), Phanloai (Phân loại), Giaban (Giá bán).

// Từ đó xây dựng một chương trình quản lý sản phẩm thời trang, trong đó:

// 1. Xây dựng lớp Shop với các thuộc tính ở phạm vi truy cập private (2 điểm)

// 2. Xây dựng lớp QuanlyShop, là danh sách các sản phẩm được nhập từ file .txt (2 điểm)

// 3. Tạo các phương thức quản lý sản phẩm theo Menu sau:

// Bấm 1: Cập nhật (Cập nhật/ Sửa lại số lượng và giá bán của sản phẩm theo mã sản phẩm, xuất ra màn hình danh sách đã thay đổi) (2 điểm)

// Bấm 2: Thống kê (Thống kê và xuất ra sản phẩm có lượng tồn kho thấp (nhỏ hơn hoặc bằng 10 sản phẩm) (2 điểm)

// Bấm 3: Mua hàng (Nhập các mã sản phẩm cần mua, số lượng, Xuất ra màn hình số tiền cần phải trả cho hóa đơn mua hàng. Trường hợp không tìm thấy mã sản phẩm hoặc số lượng lớn hơn số lượng trong danh sách thì xuất ra màn hình “Không hợp lệ”) (2 điểm)

// Bấm 0: Exit
 class Shop
    {
        // MaSP (mã sản phẩm), TenSP (tên sản phẩm), Tonkho (Tồn kho), Phanloai (Phân loại), Giaban (Giá bán)
        private string MaSP, TenSP, Phanloai;
        private int Tonkho, Giaban;
        public string maSP {get {return MaSP;}set{ MaSP=value;}}
        public string tenSP {get {return TenSP;}set{ TenSP=value;}}
        public int tonkho {get {return Tonkho;}set{ Tonkho=value;}}
        public string phanloai {get {return Phanloai;}set{ Phanloai=value;}}
        public int giaban {get {return Giaban;}set{ Giaban=value;}}
    }
class QuanlyShop
{   
    public List<Shop>DS=new List<Shop>();
    public void nhap()
    {
    string input=ReadAllText(@"qls.txt");
    foreach (var row in input.Split("\n") )
    {
        string [] filetxt =new string[5];
        j=0;
        foreach (var col in input.Split("\n"))
        {
            filetxt[j]=col.Trim();
            j++;
        }
    }
    Shop sp=new Shop();
    sp.maSP=filetxt[0];
    sp.tenSP=filetxt[1];
    sp.tonkho=Conver.ToInt32(filetxt[2]);
    sp.phanloai= res[3];
    sp.giaban=Convert.ToInt32(res[4]); 
    DS.Add(sp);   
    }
    public void xuat()
    {
        foreach (var ds in DS )
        {
            Console.WriteLine($"{ds.maSP};{ds.tenSP };" )
        }
    }
    public void capnhap()
    {
        Console.WriteLine("Nhap ma sp:")
        string ma=Console.ReadLine();
        int t=0;
        foreach (var ds in DS)
        {
            if (ds.maSP=ma)
            {
                t=1;
                int sl=Convert.ToInt32(Console.ReadLine());
                ds.tonkho=sl;
                int gia=Convert.ToInt32(Console.ReadLine());
                ds.giaban=gia;
                break;

            }
        }
        if (t==0) {Console.WriteLine("khong thay!!")}
        else {xuat();}
    }
    public void thongke()
    {
        foreach (var ds in DS)
        {
            if (ds.tonkho <=10)
            {
                Console.WriteLine($"{ds.maSP} ; {ds.tenSP} ; {ds.tonkho} ; {ds.phanloai} ; {ds.giaban} ");

            }
        }
    }
    public muahang()
    {
        Console.WriteLine("Nhap tt sp can mua:")
        int i=0, t1=0,s=0,t=0;
        while (true)
        {
            t=0;
            Console.WriteLine("Masp");
            string ma=Console.ReadLine();
            foreach (var ds in DS)
            {
                if (ds.maSP=ma)
                {
                    t=1;
                    Console.WriteLine("SL:")
                    int sl=Convert.ToInt32(Console.ReadLine());
                    if (ds.tonkho<sl) {Console.WriteLine("khong hop le!!"); break;}
                    else {s=s+sl*ds.giaban;ds.tonkho-=sl;}
                }
            }
            if (t==0) {Console.WriteLine("Không hợp lệ");}
            if (t==1)
            {
                Console.WriteLine("nhap 1 mua them, 0-kt!!")
                t1=Convert.ToInt32(Console.ReadLine());
                if (t1==0) {Console.WriteLine("So tien can trả"+s); break;}

            }
        }
    }
}

Class Program
{
    static void Main(string[ ] args)
    {
        Console.OutputEncoding=Encoding.Unicode;
        Console.InputEncoding=Encoding.Unicode;
        QuanlyShop ds=new QuanlyShop();
        ds.nhap();
        while (true)
        {
            Console.WriteLine("------MENU------\nChon so theo yeu cau");
                Console.WriteLine("#1. CAP NHAT (so luong, gia ban)");
                Console.WriteLine("#2. THONG KE (san pham co ton kho<=10)");
                Console.WriteLine("#3. MUA HANG (dua tren ma san pham và so luong)");
                Console.WriteLine("#0. EXIT");
                Console.Write("Vui long chon yeu cau:");
            int k=Conver.ToInt32(Console.ReadLine());
            if (k==0) { }
        }

    }
}
