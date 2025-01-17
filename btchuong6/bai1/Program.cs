using System;
class Hinhhoc
{
    public virtual void cv()
    {Console.WriteLine();}
    public virtual void dt()
    {Console.WriteLine();}
}
class Hinhchunhat:Hinhhoc
{
    public double Dai,Rong;
    public Hinhchunhat(double dai, double rong )
    {
        Dai=dai;
        Rong=rong;
    }
    public override void cv()
    {
        Console.WriteLine("Chu vi=" +(Dai+Rong)*2);
    }
    public override void dt()
    {
        Console.WriteLine("Dien tich=" +(Dai*Rong));
    }
}
class Hinhtron:Hinhhoc
{
    public double R;
    public Hinhtron(double r)
    {
        R=r;
    }
    public override void cv()
    {
        Console.WriteLine("Chu vi=" +(2*3.14*R));
    }
    public override void dt()
    {
        Console.WriteLine("Dien tich=" +(3.14*R*R));
    }

}
class Hinhtamgiac:Hinhhoc
{
    public double A,B,C;
    public Hinhtamgiac(double a, double b, double c)
    {
        A=a;
        B=b;
        C=c;
    }
    public override void cv()
    {
        if (A+B>C & A+C>B & B+C>A)
        {
            Console.WriteLine("Chu vi=" + (A+B+C));
        }
    }
    public override void dt()
    {
    if (A+B>C & A+C>B & B+C>A)
        {
            double p=(A+B+C)/2;
            double s=Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            Console.WriteLine("Dien tich=" + s);
        }
    }
}
class Hinhvuong:Hinhhoc
{
    public double Canh;
    public Hinhvuong(double canh)
    {Canh=canh;}
    public override void cv()
    {
        Console.WriteLine("Chu vi=" +(Canh*4));
    }
    public override void dt()
    {
        Console.WriteLine("Dien tich=" +(Canh*Canh));
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("HINH CHU NHAT");
        Console.Write("Chieu dai= ");
        double dai=double.Parse(Console.ReadLine());
        Console.Write("Chieu rong= ");
        double rong=double.Parse(Console.ReadLine());
        Hinhhoc hcn=new Hinhchunhat(dai,rong);
        hcn.cv();
        hcn.dt();
        Console.WriteLine("HINH TRON");
        Console.Write("Ban kinh= ");
        double r=double.Parse(Console.ReadLine());
        Hinhhoc ht=new Hinhtron(r);
        ht.cv();
        ht.dt();
        Console.WriteLine("HINH TAM GIAC");
        Console.Write("Canh a= ");
        double a=double.Parse(Console.ReadLine());
        Console.Write("Canh b= ");
        double b=double.Parse(Console.ReadLine());
        Console.Write("Canh c= ");
        double c =double.Parse(Console.ReadLine());
        Hinhhoc htg=new Hinhtamgiac(a,b,c);
        htg.cv();
        htg.dt();
        Console.WriteLine("HINH VUONG");
        Console.Write("Canh hinh vuong= ");
        double canh=double.Parse(Console.ReadLine());
        Hinhhoc hv=new Hinhvuong(canh);
        hv.cv();
        hv.dt();
    }
}