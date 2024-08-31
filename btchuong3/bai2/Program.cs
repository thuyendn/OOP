// // Xây dựng lớp Meo gồm:
// //  Thuộc tính: Ten, Giong, Gioitinh, Tuoi
// //  Phương thức:
// // • Hàm Khởi tạo, Hàm hủy
// // • Hàm Nhập, Xuất, Đếm
// // a) Xuất ra danh sách thông tin mèo đã nhập ra màn hình
// // b) Đếm số lượng mèo có trong danh sách

// using System;
// class meo
// {
//     public string ten;
//     public string giong;
//     public string gioitinh;
//     public int tuoi;
//     public static int dem;
//     public void info()
//     {
//         Console.WriteLine("Ten meo:{0}",ten);
//         Console.WriteLine("Giong:{0}",giong);
//         Console.WriteLine("Gioi tinh{0}",gioitinh);
//         Console.WriteLine("Tuoi:{0}",tuoi);
//     }
//     public meo()
//     {
//         ten="Xu";
//         giong="long dai";
//         gioitinh="cai";
//         tuoi=2;
//         dem++;
//     }
//     public meo(string Ten, string Giong, string Gioitinh, int Tuoi)
//     {
//         ten=Ten;
//         giong=Giong;
//         gioitinh=Gioitinh;
//         tuoi=Tuoi;
//         dem++;
//     }
//     public static int demmeo()
//     {
//         return dem;
//     }
// }
// class xuat
// {
//     static void Main()
//     {
//         meo meo1=new meo();
//         meo1.info();

//         meo meo2=new meo("Xeo","long ngan","duc",2);
//         meo2.info();

//         Console.WriteLine("So luong meo:{0}",meo.demmeo());
//     }
// }


using System;
class meo
{
    public string ten;
    public string giong;
    public string gioitinh;
    public int tuoi;
    public static int dem;
    public void nhap()
    {
        Console.Write("Ten meo: ");
        ten = Console.ReadLine();
        Console.Write("Giong: ");
        giong = Console.ReadLine();
        Console.Write("Gioi tinh: ");
        gioitinh = Console.ReadLine();
        Console.Write("Tuoi: ");
        tuoi = Convert.ToInt16(Console.ReadLine());
    }
    public meo()
    {
        ten="Xu";
        giong="long dai";
        gioitinh="cai";
        tuoi=2;
        dem++;
    }
    public meo(string Ten, string Giong, string Gioitinh, int Tuoi)
    {
        ten=Ten;
        giong=Giong;
        gioitinh=Gioitinh;
        tuoi=Tuoi;
        dem++;
    }
    public void xuat()
    {
        Console.WriteLine("Ten meo: {0}, giong: {1}, gioi tinh: {2}, tuoi: {3}",ten, giong, gioitinh, tuoi);
    }
    public static int demmeo()
    {
        return dem;
    }
}
class xuat
{
    static void Main(string[] args)
    {
        meo meo1=new meo();
        meo meo2= new meo("Xeo","long ngan","duc",2);
        meo meo3=new meo();
        
        meo1.nhap();
        meo1.xuat();
        meo2.xuat();
        meo3.xuat();
        Console.WriteLine("So luong meo:{0}",meo.demmeo());
    }
}


