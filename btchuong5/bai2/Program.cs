// using System;
// using System.Collections.Generic;
// class People
// {
//     public string Hoten, Diachi,ID;
//     public int Tuoi;
//     public People(string id, string hoten, string diachi, int tuoi)
//     {
//         ID=id;
//         Hoten=hoten;
//         Diachi=diachi;
//         Tuoi=tuoi;
//     }
//     public void nhap()
//     {
//         Console.Write("Nhap ma so:");
//         ID=Console.ReadLine();
//         Console.Write("Nhap ten:");
//         Hoten=Console.ReadLine();
//         Console.Write("Nhap tuoi:");
//         Tuoi=int.Parse(Console.ReadLine());
//         Console.Write("Nhap dia chi:");
//         Diachi=Console.ReadLine();

//     }
//     public void xuat()
//     {
//         Console.WriteLine($"Ma so: {ID}, Ten: {Hoten}, Tuoi: {Tuoi}, Dia chi: {Diachi}");
//     }
// }
// class Student:People
// {
//     public string Term;
//     public double Tp1,Tp2,Tp3;
//     public Student(string id, string hoten, string diachi, int tuoi, string term, double tp1,double tp2,double tp3):base(id, hoten, diachi, tuoi)
//     {
//         Term=term;
//         Tp1=tp1;
//         Tp2=tp2;
//         Tp3=tp3;
//     }
//     public double GPA()
//     {
//         return (Tp1+Tp2+Tp3)/3;
//     } 
//     public new void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap ten hoc phan:");
//         Term=Console.ReadLine();
//         Console.Write("Nhap diem TP1:");
//         Tp1=double.Parse(Console.ReadLine());
//         Console.Write("Nhap diem TP2:");
//         Tp2=double.Parse(Console.ReadLine());
//         Console.Write("Nhap diem TP3:");
//         Tp3=double.Parse(Console.ReadLine());
//     }
//     public void xuatsv()
//     {
//         base.xuat();
//         Console.WriteLine($"Ten hoc phan: {Term}, TP1: {Tp1}, TP2: {Tp2}, TP3: {Tp3}, GPA: {GPA()}");
//     }
// }
// class Lecture: People
// {
//     public int Knghiem;
//     public string Hvi, Cvu;
//     public Lecture(string id, string hoten, string diachi, int tuoi, int knghiem, string hvi, string cvu):base(id, hoten, diachi, tuoi)
//     {
//         Knghiem=knghiem;
//         Hvi=hvi;
//         Cvu=cvu;
//     }
//     public new void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap Kinh nghiem (nam): ");
//         Knghiem=Convert.ToInt32(Console.ReadLine());
//         Console.Write("Nhap Hoc vi: ");
//         Hvi=Console.ReadLine();
//         Console.Write("Nhap Chuc vu: ");
//         Cvu=Console.ReadLine();

//     }
//     public static void sapxep(List<Lecture> lectures)
//     {
//     for (int i = 0; i < lectures.Count - 1; i++)
//     {
//         for (int j = i + 1; j < lectures.Count; j++)
//         {
//             if (lectures[j].Knghiem > lectures[i].Knghiem)
//             {
//                 // Hoán đổi vị trí giảng viên i và j
//                 Lecture temp = lectures[i];
//                 lectures[i] = lectures[j];
//                 lectures[j] = temp;
//             }
//         }
//     }

//     for (int i = 0; i < lectures.Count - 1; i++)
//     {
//         if (lectures[i].Knghiem == lectures[i + 1].Knghiem)
//         {
//             lectures.RemoveAt(i + 1);
//             i--;
//         }
//     }
//     }
//     public void xuatgv()
//     {
//         Console.WriteLine($"Kinh nghiem: {Knghiem} nam, Hoc vi: {Hvi}, Chuc vu: {Cvu}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         List<Lecture> L=new List<Lecture>();
//         Console.Write("So luong giang vien:");
//         int sl= Convert.ToInt32(Console.ReadLine());
//         for (int i=0; i<sl;i++)
//         {
//             Lecture p1=new Lecture("", "", "", 0, 0, "", "");
//             p1.nhap();
//             L.Add(p1);
//         }
//         Lecture.sapxep(L);
//         Console.WriteLine("Thong tin Giang vien sau khi sap xep:");
//         foreach (Lecture lecturer in L)
//             {
//                 lecturer.xuatgv();
//             }

//     }
// }
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
