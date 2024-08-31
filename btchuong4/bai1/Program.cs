// // Bài 1: Xây dựng lớp Phanso (Phân số) gồm:
// //  Thuộc tính: Tuso, Mauso (Tử số, Mẫu số)
// //  Phương thức:
// // • Hàm Khởi tạo không Tham số, Hàm hủy
// // • Hàm Nhập, xuất
// // • Hàm Cong(), Tru(), Nhan(),Chia()
// // Tính Tổng, Hiệu, Tích, Thương 2 phân số A và B rồi in ra kết
// // quả trên màn hình
using System;
class Phanso
{
    private double tu, mau;
    public double Tu
    {
        get { return tu;}
        set { tu=value;}
    }
    public double Mau
    {
        get { return mau;}
        set 
        { 
            if (value !=0)
                mau=value;
            else
                Console.WriteLine("Mau so khong duoc bang 0");
        }
    }
    public Phanso Cong(Phanso a)
    {
        Phanso kq= new Phanso();
        kq.Tu=this.Tu * a.Mau + a.Tu * this.Mau;
        kq.Mau=this.Mau * a.Mau;
        return kq;    
    }
    public Phanso Tru(Phanso a)
    {
        Phanso kq= new Phanso();
        kq.Tu=this.Tu * a.Mau - a.Tu * this.Mau;
        kq.Mau=this.Mau * a.Mau;
        return kq;    
    }
    public Phanso Nhan(Phanso a)
    {
        Phanso kq= new Phanso();
        kq.Tu=this.Tu * a.Tu;
        kq.Mau=this.Mau * a.Mau;
        return kq;    
    }
    public Phanso Chia(Phanso a)
    {
        Phanso kq= new Phanso();
        kq.Tu=this.Tu * a.Mau;
        kq.Mau=this.Mau * this.Tu;
        if (kq.Mau<0)
        {
            kq.Tu=-kq.Tu;
            kq.Mau=-kq.Mau;
        }
        return kq;    
    }
    public void xuat()
    {
        Console.WriteLine("{0}/{1}",Tu,Mau);      
    }
    public void Nhap()
    {
        Console.Write("Nhap tu so: ");
        Tu=double.Parse(Console.ReadLine());
        Console.Write("Nhap mau so: ");
        Mau=double.Parse(Console.ReadLine());
    }
}
class Program
{
    static void Main()
    {
        Phanso A=new Phanso();
        Phanso B=new Phanso();

        Console.WriteLine("Nhap phan so A");
        A.Nhap();
        Console.WriteLine("Nhap phan so B");
        B.Nhap();

        Console.Write("Tong hai phan so la:");
        Phanso Tong=A.Cong(B);
        Tong.xuat();

        Console.Write("Hieu hai phan so la:");
        Phanso Hieu=A.Tru(B);
        Hieu.xuat();

        Console.Write("Tich hai phan so la:");
        Phanso Tich=A.Nhan(B);
        Tich.xuat();

        Console.Write("Thuong hai phan so la:");
        Phanso Thuong=A.Chia(B);
        Thuong.xuat();

    }
}


