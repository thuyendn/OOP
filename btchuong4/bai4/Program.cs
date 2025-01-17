// // : Xây dựng một ứng dụng quản lý điểm học phần OOP
// // của sinh viên có chứa nội dung như sau:
// //  Lớp thông tin sinh viên (Info) bao gồm: ID, Hoten, Group
// // lần lượt là Mã Sinh viên, Họ Tên sinh viên, Lớp sinh hoạt
// //  Lớp điểm thành phần (DiemTP) bao gồm TP1, TP2, TP3
// // Các phương thức yêu cầu trong bài:
// // • Nhập mã sinh viên, Họ và tên sinh viên và Lớp SH
// // • Xuất số lượng sinh viên có trong lớp học phần OOP
// // • Nhập điểm TP1, TP2, TP3 cho mỗi sinh viên
// // • Tính điểm TB = TP1*0.1+TP2*0.3+TP3*0.6
// // • Xuất ra thông tin của sinh viên và điểm trung bình môn
// // OOP

// using System;
// class Info
// {
//     private static List<Info> sv=new List<Info>(); 
//     private string id;
//     private string hoten, group;
//     public string Id
//     {
//         get { return id; }
//         set { id=value; }
//     }
//     public string Hoten
//     {
//         get { return hoten; }
//         set { hoten=value; }
//     }
//     public string Group
//     {
//         get { return group; }
//         set { group=value; }
//     }
    
//     public void nhap()
//     {
//         Console.Write("Nhap ma sinh vien:");
//         Id=Console.ReadLine();

//         Console.Write("Nhap ho ten sinh vien:");
//         Hoten=Console.ReadLine();

//         Console.Write("Nhap lop sinh hoat:");
//         Group=Console.ReadLine();

//         sv.Add(this);      //thêm đối tươngj sv hiện tại vào list
//     }
//     public static int SoluongSV()
//     {
//         return sv.Count;
//     }
//     public void xuatthongtin()
//     {
//         Console.WriteLine("Ma sinh vien:{0}",Id);
//         Console.WriteLine("Ho ten sinh vien:{0}",Hoten);
//         Console.WriteLine("Lop sinh hoat:{0}", Group);
//     }
// }
// class Diemtp
// {

//     private double tp1;
//     private double tp2;
//     private double tp3;

//     public double TP1
//     {
//         get { return tp1;}
//         set {tp1=value;}
//     }
//     public double TP2
//     {
//         get { return tp2;}
//         set {tp2=value;}
//     }
//     public double TP3
//     {
//         get { return tp3;}
//         set {tp3=value;}
//     }
//     public double Tinhdiemtb()
//     {
//         return (tp1*0.1)+(tp2*0.3)+(tp3*0.6);
//     }
//     public void nhapdiemtp()
//     {
//         Console.Write("Nhap diem TP1:");
//         TP1= double.Parse(Console.ReadLine());
//         Console.Write("Nhap diem TP2:");
//         TP2= double.Parse(Console.ReadLine());
//         Console.Write("Nhap diem TP3:");
//         TP3= double.Parse(Console.ReadLine());
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         List<Info> danhsachsv= new List<Info>();
//         do
//         {
//             Info SV=new Info();
//             Diemtp DiemTP=new Diemtp();

//             SV.nhap();
//             DiemTP.nhapdiemtp();
//             Console.WriteLine("Thông tin sinh viên:");
//             SV.xuatthongtin();
//             Console.WriteLine("Diem trung binh mon OOP:{0}",DiemTP.Tinhdiemtb());
//             danhsachsv.Add(SV);
//             Console.Write("Nhap tiep thong tin SV (Co/Khong):");
//         }
//         while (Console.ReadLine()=="Co");
//         Console.WriteLine("So luong sinh vien trong lop: ", Info.SoluongSV());
//     }
// }


using System;
class Info
{
    public string Id, Hoten,Group;
    public static int count=0;
    public Diemtp diem=new Diemtp();
    public void nhap()
    {
        count++;
        Console.Write("Nhap ma sinh vien:");
        Id=Console.ReadLine();
        Console.Write("Nhap ho ten sinh vien:");
        Hoten=Console.ReadLine();
        Console.Write("Nhap lop sinh hoat:");
        Group=Console.ReadLine();
        diem.nhapdiemtp();  
    }
    public void xuatinfo()
    {
        Console.WriteLine("Ma sinh vien:"+Id+" ,Ho ten sinh vien:"+Hoten+" ,Lop sinh hoat:"+Group+" ,Diem trung binh mon OOP la:"+diem.Tinhdiemtb());
    }
}
class Diemtp
{
    double tp1,tp2,tp3;
    public void nhapdiemtp()
    {
        Console.Write("Nhap diem TP1:");
        tp1=double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP2:");
        tp2=double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP3:");
        tp3=double.Parse(Console.ReadLine());
    }
    public double Tinhdiemtb()
    {
        return (tp1*0.1)+(tp2*0.3)+(tp3*0.6);
    }
}
class Program
{
    static void Main()
    {
        Info sv1=new Info();
        Info sv2=new Info();
        Info sv3=new Info();
        sv1.nhap();
        sv2.nhap();
        sv3.nhap();
        Console.WriteLine("Thong tin sinh vien:");
        sv1.xuatinfo();
        sv2.xuatinfo();
        sv3.xuatinfo();
        Console.WriteLine("So luong sinh vien trong hoc phan OOP la: {0}",Info.count);
    }
}