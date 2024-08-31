using System;

public class People
{
    public string ID;
    public string Hoten;
    public int Tuoi;
    public string Diachi;

    public People(string ID = "", string Hoten = "", int Tuoi = 0, string Diachi = "")
    {
        this.ID = ID;
        this.Hoten = Hoten;
        this.Tuoi = Tuoi;
        this.Diachi = Diachi;
    }

    public void Nhap()
    {
        Console.Write("Nhap ID: ");
        ID = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        Hoten = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap dia chi: ");
        Diachi = Console.ReadLine();
    }

    public void Xuat()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Ho ten: " + Hoten);
        Console.WriteLine("Tuoi: " + Tuoi);
        Console.WriteLine("Dia chi: " + Diachi);
    }
}

public class Students : People
{
    public string Term;
    public double TP1;
    public double TP2;
    public double TP3;

    public Students(string ID = "", string Hoten = "", int Tuoi = 0, string Diachi = "", string Term = "", double TP1 = 0, double TP2 = 0, double TP3 = 0) : base(ID, Hoten, Tuoi, Diachi)
    {
        this.Term = Term;
        this.TP1 = TP1;
        this.TP2 = TP2;
        this.TP3 = TP3;
    }

    public double GPA()
    {
        double diem_tb = (TP1 + TP2 + TP3) / 3;
        if (diem_tb >= 9)
            return 4.0;
        else if (diem_tb >= 8)
            return 3.5;
        else if (diem_tb >= 7)
            return 3.0;
        else if (diem_tb >= 6)
            return 2.5;
        else if (diem_tb >= 5)
            return 2.0;
        else if (diem_tb >= 4)
            return 1.5;
        else if (diem_tb >= 3)
            return 1.0;
        else if (diem_tb >= 2)
            return 0.5;
        else
            return 0.0;
    }

    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap ten hoc phan: ");
        Term = Console.ReadLine();
        Console.Write("Nhap diem TP1: ");
        TP1 = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP2: ");
        TP2 = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem TP3: ");
        TP3 = double.Parse(Console.ReadLine());
    }

    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Ten hoc phan: " + Term);
        Console.WriteLine("Diem TP1: " + TP1);
        Console.WriteLine("Diem TP2: " + TP2);
        Console.WriteLine("Diem TP3: " + TP3);
        Console.WriteLine("Diem trung binh: " + GPA());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Students sv = new Students();
        sv.Nhap();
        sv.Xuat();
    }
}
