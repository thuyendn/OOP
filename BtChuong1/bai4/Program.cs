using System;
namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n=int.Parse(Console.ReadLine());
            int[,] A=new int[n,n];
            for (int i=0;i<n;i++)  //nhập kq từng trận
            {
                for (int j=0;j<n;j++)
                {
                    A[i,j]=int.Parse(Console.ReadLine());
                }
            }
            int[] diem=new int[n]; //tính điểm từng đội
            int[] thang=new int[n];
            int[] thua=new int[n];
            for (int i=0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    if (i==j)  //khong tự đấu với mình
                    {
                        A[i,j]=0; 
                    }
                    else
                    {
                        if (A[i,j]==3)
                        {
                            diem[i]+=3;
                            thang[i]++;
                            thua[j]++;
                        }
                        if (A[i,j]==1)
                        {
                            diem[i]++;
                            diem[j]++;
                        }
                        if (A[i,j]==0)
                        {
                            diem[j]+=3;
                            thang[j]++;
                            thua[i]++;
                        }
                    }
                }
            }
            int maxdiem=diem[0];
            int maxthang=thang[0];
            for (int i=1;i<n;i++)
            {
                if (diem[i]>maxdiem)
                {
                    maxdiem=diem[i];
                }
                if (thang[i]>maxthang)
                {
                    maxthang=thang[i];
                }
            }
            // a) In ra màn hình tất cả các đội có số điểm lớn nhất
            for (int i=0;i<n;i++)
            {
                if (diem[i]==maxdiem)
                {
                    Console.WriteLine(i+1);
                }
            }
            // b) In ra màn hình tất cả các đội có số trận thắng nhiều hơn thua?

            for (int i=0;i<n;i++)
            {
                if (thang[i]>thua[i])
                {
                    Console.WriteLine(i+1);
                }
            }
            // c) Hãy chỉ ra các đội không thua trận nào?
            for (int i=0;i<n;i++)
            {
                if (thua[i]==0)
                {
                    Console.Write(i+1);
                }
            }
        }
    }
}



