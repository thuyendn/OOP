// See https://aka.ms/new-console-template for more information
// using system;
// namespace B2;
// int i,j,s;
// console.write("Nhap vao so luong bi gio do:");
// // i=Convert.ToInt32(Console.Readline());
// i=int.Parse(Console.Readline());
// console.write("Nhap vao so luong bi gio xanh:");
// j=Convert.ToInt32(Console.Readline());
// s=i+j;
// console.write("So bi gio do la {0}, So bi gio xanh la {1}, So bi ca gio {2}",i,j,s)

// int n,i;
// Console.WriteLine("Nhap so luong gio hang");
// n=int.Parse(Console.ReadLine());
// int [] Gio = new int [n];
// Console.WriteLine("Nhap so luong san pham");
// for (i=1; i<=n,i++);
//     Gio[i]=int.Parse(Console.ReadLine());
using System;
namespace B2
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int a,b,kq=0;
            Console.WriteLine("Nhap 2 so");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            TBP1(a,b);
            TBP2(a,b,kq);
            Console.WriteLine("TBP kq tra ve qua ten ham: {0}",TBP3(a,b));
        }
        static void TBP1(int a,int b)
        {
            Console.WriteLine("Tong binh phuong 2 so: {0}",a*a+b*b);

        }
        static void TBP2(int a, int b, int kq)
        {
            kq=a*a+b*b;
            Console.WriteLine("TBP tham so kq mang kq: {0}",kq);

        }
        static int TBP3( int a, int b)
        {
            return a*a+b*b;
        }
    }
}










