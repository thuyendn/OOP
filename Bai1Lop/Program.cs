using System;

class Program
{
static void Main(string[] args)
    {   
        int a, b; 
        Console.Write("Nhap a= ");
        a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap b= ");
        b=Convert.ToInt32(Console.ReadLine());

        int dem=0;
        for (int i=a; i<=b; i++)
        {
            bool SNT = true;  //bool chỉ nhận một trong 2 giá trị T/F, yes/no 
            if (i<2)
            {
                SNT=false;
            }
            else
            {
                for (int j=2; j<=Math.Sqrt(i); j++)
                {
                    if (i%j==0)
                    {
                        SNT=false;
                        break;
                    }
                }
            }           
            if (SNT)
            {
                dem++;
            }
        }
        Console.Write("Co {0} so nguyen to", dem);
    }
}
