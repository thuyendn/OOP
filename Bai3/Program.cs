// Bài 3. Viết chương trình thực hiện các yêu cầu sau:
// - Nhập vào từ bàn phím hai số nguyên a và b
// - Tính tổng bình phương của a và b

// a. Hàm TBP(a,b): kết quả được in lên màn hình
// b. Hàm TBP(a,b,kq): tham số kq sẽ mang kết quả
// c. Hàm TBP(a,b): kết quả được trả về qua tên hàm.
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         int a=int.Parse(Console.ReadLine());
//         int b=int.Parse(Console.ReadLine());
//         int TBP=a*a+b*b;
//         Console.Write("Tong binh phuong 2 so nguyen la {0}",TBP);
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int a=int.Parse(Console.ReadLine());
//         int b=int.Parse(Console.ReadLine());
//         int TBP=a*a+b*b;
//         InKQ(TBP);
//     }
//     static void InKQ(int TBP)
//     {
//         Console.WriteLine("TBP= {0}", TBP);
//     }
// }


using System;

class Program
{
    private static int Tinh(int n)
    {
        int S = 0;
        for (int i = 1; i <= n; i++)
            S += i;
        return S;
    }

    static void Main(string[] args)
    {
        // Thực hiện thêm mã trong hàm Main nếu cần
        // Ví dụ: Console.WriteLine(Tinh(10));
    }
}




