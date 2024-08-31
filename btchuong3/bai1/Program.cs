// // // // // //  BÀI 1: Xây dựng lớp Sach gồm:
// // // // // //  Thuộc tính: Tensach, Tacgia, NamXB, Soluong
// // // // // //  Phương thức:
// // // // // // • Hàm Khởi tạo(CÓ VÀ KHÔNG CÓ THAM SỐ), Hàm hủy
// // // // // // • Hàm Nhập, Xuất
using System;
class sach
{
    public string tensach;
    public string tacgia;
    public int namxb;
    public int soluong;

    public void nhap()
    {
        Console.Write("Ten sach: ");
        tensach=Console.ReadLine();
        Console.Write("Tac gia: ");
        tacgia=Console.ReadLine();
        Console.Write("Nam xuat ban: ");
        namxb=Convert.ToInt32(Console.ReadLine());
        Console.Write("So luong: ");
        soluong=Convert.ToInt32(Console.ReadLine());
    }

    public sach()
    {
        tensach="So do";
        tacgia="Vu Trong Phung";
        namxb=1936;
        soluong=2;
    }

    public sach(string Tensach, string Tacgia, int Namxb, int Soluong)
    {
        tensach=Tensach;
        tacgia=Tacgia;
        namxb=Namxb;
        soluong=Soluong;
    }

    public void xuat()
    {
        Console.WriteLine("Ten sach:{0}, Tac gia:{1}, Nam xuat ban:{2}, So luong:{3}", tensach, tacgia, namxb, soluong);
    }
}

class Xuat
{
    static void Main(string[] args)
    {
        sach s1=new sach();
        sach s2= new sach("Mat biec", "Nguyen Nhat Anh", 2004, 3);
        sach s3=new sach();
        s1.nhap();
        s1.xuat();
        s2.xuat();
        s3.xuat();
    }
}
