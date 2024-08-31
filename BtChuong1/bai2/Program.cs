using System;
namespace bai2 
{
    class Program
    {
        static void Nhap(out double a, out double b,out char ToanTu)
        {
        Console.Write("a= ");
        a=Convert.ToDouble(Console.ReadLine());
        Console.Write("b= ");
        b=Convert.ToDouble(Console.ReadLine());
        Console.Write("Toan tu: ");
        ToanTu=Convert.ToChar(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double a,b, KQ=0;
            char ToanTu;
            string Tieptuc;
            while (true)
            {
                Nhap(out a, out b, out ToanTu);
                Thuchien( a, b,  ToanTu, ref KQ);
                KQua(a,b,ToanTu, KQ);
                Console.Write("Tiep tuc:");
                Tieptuc=Console.ReadLine();
                if (Tieptuc=="t" | Tieptuc=="T" )
                {
                    break;
                }
            }
        }
        static void Thuchien(double a, double b, char ToanTu, ref double KQ)
        {
            KQ=0;
            switch (ToanTu)
            {
                case '+':
                    KQ=a+b;
                    break;
                case '-':
                    KQ=a-b;
                    break;
                case '*':
                    KQ=a*b;
                    break;
                case '/':
                    if (b!=0)
                    {
                        KQ=a/b;
                    }
                    else
                        Console.Write("Khong hop le");
                    break;

            }
        }
        static void KQua(double a, double b, char ToanTu,double KQ)
        {
            Console.WriteLine("{0}{1}{2}={3}",a,ToanTu,b,KQ);
        }
    }
}
    
    