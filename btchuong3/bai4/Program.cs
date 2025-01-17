using System;
class Triangle
{
    public int a,b,c,cv,dt;
    public void nhap()
    {
        Console.Write("a=");
        a=int.Parse(Console.ReadLine());
        Console.Write("b=");
        b=int.Parse(Console.ReadLine());
        Console.Write("c=");
        c=int.Parse(Console.ReadLine());
    }
    public void xuat()
    { Console.WriteLine("a={0},b={1},c={2}",a,b,c);}
    public bool tamgiac()
    {return (a+b>c || a+c>b || b+c>1);}
    public double chuvi()
    {return a+b+c;}
    public double dientich()
    {
        double p=chuvi()/2;
        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    }
    public static void Main()
    {
        Triangle Tamgiac= new Triangle();
        int choice;
        do
        {
            Console.WriteLine("1.Nhap cac canh tam giac:");
            Console.WriteLine("2.Tinh chu vi va dien tich tam giac:");
            Console.WriteLine("3.Xuat gia tri cac canh: ");
            Console.WriteLine("0.Thoat!!");
            Console.WriteLine("Nhap lua chon: ");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Tamgiac.nhap();
                    break;
                case 2: if (Tamgiac.tamgiac())
                    {
                    double Chuvi=Tamgiac.chuvi();
                    double Dientich=Tamgiac.dientich();
                    Console.WriteLine("Chu vi={0}",Chuvi);
                    Console.WriteLine("Dien tich={0}",Dientich);
                    }
                    else { Console.WriteLine("Khong hop le!!!");}
                    break;
                case 3: Tamgiac.xuat();
                    break;
                case 0: Console.WriteLine("Ket thuc chuong trinh !!!");
                    break;
                default: Console.WriteLine("Lua chon khong hop le");
                    break;
            }

        }
        while (choice!=0);

    }

}