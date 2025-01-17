using System;
class hinhtron
{
    public double R,D,S;
    public hinhtron(double r)
    {
        R=r;
        D=2*r;
        S=3.14*r*r;

    }
    public void xuat()
    {
        Console.WriteLine($"Ban kinh la= {R}, duong kinh= {D}");
    }
    public void Xuatdt()
    {
        Console.WriteLine($"Dien tich= {S}");
    }
}
class hinhcau: hinhtron
{
    public double newS, V;
    public hinhcau(double r): base(r)
    {
        newS=4*3.14*r*r;
        V=4/3*3.14*r*r*r;
    } 
    public void xuatHC()
    {
        Console.WriteLine($"Dien tich hinh cau= {newS}, the tich hinh cau= {V}");
    }
}
class hinhtru: hinhtron
{
    public double H,cv, dt, sxq, stp,Vht;
    public hinhtru(double r, double h) : base(r)
    {
        H=h;
        cv=2*3.14*r;
        dt=S;
        sxq=S*h;
        stp=sxq +cv;
        Vht=dt*h;
    }
    public void xuatht()
    {
        Console.WriteLine($"chieu cao= {H}, chu vi mat day= {cv}, dien tich xung quanh= {sxq}, dien tich toan phan= {stp}, the tich hinh tru= {Vht}");
    }
}
public class Program
{
    
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        double Rtron=Convert.ToDouble(Console.ReadLine());
        hinhtron htron=new hinhtron(Rtron);
        htron.xuat();
        htron.Xuatdt();

        Console.Write("Nhap ban kinh hinh cau:");
        double Rcau=Convert.ToDouble(Console.ReadLine());
        hinhcau hcau=new hinhcau(Rcau);
        hcau.xuatHC();

        Console.Write("Nhap ban kinh hinh tru:");
        double Rtru=Convert.ToDouble(Console.ReadLine());
        Console.Write("Chieu cao cua hinh tru:");
        double Htru=Convert.ToDouble(Console.ReadLine());
        hinhtru htru=new hinhtru(Rtru,Htru);
        htru.xuatht();

    }
}
