// class Program
// { 
//     static void Main(string[] args)
//     {
//         int a=5,b=10;
//         Console.Write("a="+a);
//         Console.Write("\nb="+b);
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         int Tuoi; string HoTen;
//         Console.Write("Ho va ten:");
//         HoTen = Console.ReadLine();

//         Console.Write("Tuoi:");
//         Tuoi=Convert.ToInt32(Console.ReadLine());

//         Console.Write("Xin chao ban: {0},Chuc mung sinh nhat lan thu: {1}",HoTen,Tuoi);
//         Console.ReadKey();
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         int n=5;
//         if (n<0)
//         {
//             Console.Write("The number is negative");
//         }
//         else 
//         {
//             Console.Write("The number is positive");
//         }
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         int i=1;
//         while (i<10)
//         {
//             Console.Write(i);
//             i+=1;
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         int i=1;
//         for ( i=1; i<=10;i++)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        int i=1;
        for ( i=1; i<=10;i++)
        {
            if (i%2!=0) continue;
            Console.WriteLine(i+"");  
        }
    }
}
