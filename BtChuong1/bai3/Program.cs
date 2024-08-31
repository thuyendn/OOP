using System;
namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] a;
            double tong=0;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            a =new double[n];
        // cau a
            for (int i=0; i<n; i++)
            {
                a[i]=Convert.ToDouble(Console.ReadLine());
            //     if (a[i]<0)
            //     {
            //         tong+=Math.Abs(a[i]);
            //     }
            // }
            // Console.WriteLine("Tong={0}",tong);



        // // // cau b
        //     int vtrimin=0, vtrimax=0;
        //     double max=a[0];
        //     double min=a[0];
        //     for (int i=1;i<n;i++)
        //     {
        //         if (a[i]<min)
        //         {
        //             min=a[i];
        //             vtrimin=i;
        //         }
        //         if (a[i]>max)
        //         {
        //             max=a[i];
        //             vtrimax=i;
        //         }
        //     }
        //     double tich=1;
        //     if (vtrimin<vtrimax)
        //     {
        //         for (int i=vtrimin+1;i<vtrimax;i++)
        //         {
        //             tich*=a[i];
        //         }
        //     }
        //     else if (vtrimin>vtrimax)
        //     {
        //         for (int i=vtrimax+1;i<vtrimin;i++)
        //         {
        //             tich*=a[i];
        //         }
        //     }
        //     Console.WriteLine("Tich={0}",tich);
        
            // cau c
            // Array.Sort(a);
            // Console.Write("A_tang=");
            // foreach (double x in a)
            // {
            //     Console.Write("{0} ",x);
            // }
            // Console.WriteLine();


                        // for (int i=0;i<n;i++)
            // {
            //     for (int j=i+1;j<n;j++)
            //     {
            //         if (a[i]>a[j])
            //         {
            //             double sx=a[i];
            //             a[i]=a[j];
            //             a[j]=sx;
            //         }
            //     }
            // }
            // for (int i=0; i<n; i++)
            // {
            //     Console.Write("{0} ",a[i]);
            }


            int[] b=new int[a.Length];
            for (int i=0;i<a.Length;i++)
            {
                b[i]=(int)(a[i]);
            }
            int[] c=new int[b.Length];
            int schan=0;
            int sle=b.Length-1;
            foreach (int x in b)
            {
                if (x%2==0)
                {
                    c[schan]=x;
                    schan++;
                }
                else
                {
                    c[sle]=x;
                    sle--;
                }
            }
        Console.Write("A_biendoi=");
        for (int i=0;i<c.Length;i++)
        {
            Console.Write(c[i]);
            if (i<c.Length-1)
            {
                Console.Write(",");
            }
        }

        }
    }
}

