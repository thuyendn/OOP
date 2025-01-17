using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //     class Hinhchunhat
// //         {
// //         public float dai;
// //         public float rong;
// //         public void nhap()
// //         {
// //             Console.WriteLine("Nhap chieu dai: ");
// //             dai=float.Parse(Console.ReadLine());
// //             Console.WriteLine("Nhap chieu rong: ");
// //             rong=float.Parse(Console.ReadLine());

// //         }
// //         public void Xuat()
// //         {
// //             Console.WriteLine("dai={0},rong={1}",dai,rong);

// //         }
// //         public float chuvi()
// //         {
// //             return(dai+rong)*2;
// //         }
// //         }
// //     }
// // }

// using System;

// class Hinhchunhat
// {
//     public float dai;
//     public float rong;

//     public void Nhap()
//     {
//         Console.WriteLine("Nhap chieu dai: ");
//         dai = float.Parse(Console.ReadLine());
//         Console.WriteLine("Nhap chieu rong: ");
//         rong = float.Parse(Console.ReadLine());
//     }

//     public void Xuat()
//     {
//         Console.WriteLine("dai={0}, rong={1}", dai, rong);
//     }

//     public float ChuVi()
//     {
//         return (dai + rong) * 2;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Hinhchunhat hinh = new Hinhchunhat();
//         hinh.Nhap();
//         hinh.Xuat();
//         Console.WriteLine("Chu vi: " + hinh.ChuVi());
//     }
// }

class Hinhchunhat
{
    public float dai;
    public float rong;
    public void nhap()
    {
        Console.WriteLine("Nhap chieu dai: ");
        dai=float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong: ");
        rong=float.Parse(Console.ReadLine());

    }
    public void Xuat()
    {
        Console.WriteLine("dai={0},rong={1}",dai,rong);

    }
    public float chuvi()
    {
        return(dai+rong)*2;
    }
}
class inra
{
    static void Main()
    {
        Hinhchunhat h=new Hinhchunhat();
        h.nhap();
        h.Xuat();
        Console.WriteLine("Chu vi hcn:{0}",h.chuvi());
        Console.ReadLine();

    }
}



// }
// class Tinh
// {
//     static void Main()
//     {
//         //Tajo đối tượng: 
//         Hinhchunhat hcn=new Hinhchunhat();
//         hcn.Nhap()
//         hcn.Xuat()
//         Console.Writeline("Chu vi hcn la{0}",hcn.Chuvi())
//         Console.Writeline("dt hcn la{0}",hcn.Chuvi())
    
//     }
// }