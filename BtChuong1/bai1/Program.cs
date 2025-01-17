using System;
namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string HoTen, Lopsh;
            int i;
            double[] A = new double[4];
            Console.Write("Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Lop: ");
            Lopsh = Console.ReadLine();
            Console.Write("Diem_QTH: ");
            A[0]=double.Parse(Console.ReadLine());
            Console.Write("Diem_HTTTQL: ");
            A[1]=double.Parse(Console.ReadLine());
            Console.Write("Diem_CSLT: ");
            A[2]=double.Parse(Console.ReadLine());
            Console.Write("Diem_Triet: ");
            A[3]=double.Parse(Console.ReadLine());
            double s=0;
            for (i=0; i<4; i++)
            {
                if (A[i] < 5)
                {
                    s=s+1;
                }
                else if (A[i]>=5 && A[i]<7)
                {
                    s=s+2;
                }
                else if (A[i]>=7 && A[i]<8.5)
                {
                    s=s+3;
                }
                else
                {
                    s=s+4;
                }
            }
            s=s/4;
            string loai;
            if (s>=3.6){loai="Xuat sac";}
            else if (s>=3.2){loai="Gioi";}
            else if (s>=2.5){loai="Kha";}
            else if (s>=2){loai="Trung binh";}
            else {loai="Yeu";}
            Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai {3}",HoTen.ToUpper(),Lopsh,s,loai);
        }
    }
}






