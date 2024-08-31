// : Xây dựng lớp Tamgiac (Tam giác) gồm:
//  Thuộc tính: Cạnh a, Cạnh b, Cạnh c
//  Phương thức:
// • Hàm Khởi tạo không Tham số, Hàm hủy
// • Hàm Nhập, xuất
// • Hàm Kiemtra()
// Xuất ra màn hình kiểu của tam giác (Tam giác thường, tam
// giác vuông, tam giác cân, tam giác vuông cân, tam giác đều)
using System;
class Tamgiac
{
    private double a,b,c;
    public double A
    {
        get {return a;}
        set {a=value;}
    }
    public double B
    {
        get {return b;}
        set {b=value;}
    }
    public double C
    {
        get {return c;}
        set {c=value;}
    }
    public void nhap()
    {
        Console.Write("a=");
        A=double.Parse(Console.ReadLine());
        Console.Write("b=");
        B=double.Parse(Console.ReadLine());
        Console.Write("c=");
        C=double.Parse(Console.ReadLine());
    }
    public void ktra()
    {
        if (A+B>C && A+C>B && B+C>A)
        {
            if (A==B && B==C)
            {
                Console.WriteLine("Day la tam giac deu.");
            }
            else if (A==B || B==C || A==C)
            {
                if (A*A + B*B==C*C || A*A+C*C==B*B || B*B + C*C==A*A)
                {
                    Console.WriteLine("Day la tam giac vuong can.");
                }
                else
                {
                    Console.WriteLine("Day la tam giac can.");
                }
            }
            else if (A*A + B*B==C*C || A*A+C*C==B*B || B*B + C*C==A*A)
            {
                Console.WriteLine("Day la tam giac vuong.");
            }
            else
            {
                Console.WriteLine("Day la tam giac thuong.");
            }
        }
        else
        {
            Console.WriteLine("Khong phai la tam giac.");
        }
    }
    public void xuat()
    {
        ktra();
    }
}
class Program
{
    static void Main()
    {
        Tamgiac tg=new Tamgiac();
        Console.WriteLine("Nhap cac canh cua tam giac.");
        tg.nhap();
        tg.xuat();
    }
}