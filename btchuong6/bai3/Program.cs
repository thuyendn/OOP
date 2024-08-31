// using System;

// abstract class Edition
// {
//     public string Title{ get; set; };
//     public string Author{ get; set; };
//     public Edition(string title, string author)
//     {
//         Title=title;
//         Author=author;
//     }
//     public abstract void thongtin();
//     public bool timtgia(string tentgia)
//     {
//         return Author==tentgia;
//     }
// }
// class Book:Edition
// {
//     public int Year;
//     public string Publisher;
//     public Book(string title, string tacgia, int year, string publisher):base(title,tacgia)
//     {
//         Year=year;
//         Publisher=publisher;
//     }
//     public override void thongtin()
//     {
//         Console.WriteLine($"Book: {Title} by {Author}, Year: {Year}, Publisher: {Publisher}");
//     }
// }
// class Article : Edition
// {
//     public string Journal;
//     public int Year;
//     public Article(string title, string tacgia,string journal, int year):base(title,tacgia)
//     {
//         Journal=journal;
//         Year=year;
//     }
//     public override void thongtin()
//     {
//         Console.WriteLine($"Article: {Title} by {Author}, Journal: {Journal}, Year: {Year}");
          
//     }
// }
// class OnlineResoure:Edition
// {
//     public string Link;
//     public string Abstract;
//     public OnlineResoure(string title, string tacgia,string link,string abstractt):base(title,tacgia)
//     {
//         Link=link;
//         Abstract=abstractt;
//     }
//     public override void thongtin()
//     {Console.WriteLine($"Online Resource: {Title} by {Author}, Link: {Link}, Abstract: {Abstract}");}
// }
// class Program
// {
//     static void Main()
//     {
//         Edition[] ds=new Edition[];
//         {
//             new Book("Ten sach: Mat biec.","Tac gia: Nguyen Nhat Anh.",2004,".Nha xuat ban: Tuoi tre.");
//             new Article("Ten bao: Hoa phuong do.","Thieu nhi.","Tap chi.",2023);
//             new OnlineResoure("Bao la cai.","Tac gia: Nha bao A.","Link:htpps/...","Nham nhi.");
//         }
//     };
//     Console.WriteLine("Thong tin moi doi tuong:");
//     foreach (var edition in ds)
//         {
//             edition.thongtin();
//         }

//      Array.Sort(ds, (x, y) => String.Compare(x.Title, y.Title, StringComparison.OrdinalIgnoreCase));
//      Console.WriteLine("Sắp xếp danh mục các ấn phẩm:");
//         foreach (var edition in ds)
//         {
//             edition.thongtin();
//         }

//     Console.WriteLine("\nNhap ten tac gia can tim: ");
//     string tentgiacantim = Console.ReadLine();
//     Console.WriteLine($"\nCac tac pham cua tac gia {tentgiacantim}:");
//         foreach (var edition in ds)
//         {
//             if (edition.timtgia(tentgiacantim))
//             {
//                 edition.thongtin();
//             }
//         }
    
// }

using System;

abstract class Edition
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Edition(string title, string author)
    {
        Title=title;
        Author=author;
    }
    public abstract void thongtin();

    public bool timtgia(string tentgia)
    {
        return Author==tentgia;
    }
}

class Book : Edition
{
    public int Year;
    public string Publisher;

    public Book(string title, string tacgia, int year, string publisher) : base(title, tacgia)
    {
        Year=year;
        Publisher=publisher;
    }
    public override void thongtin()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}, Year: {Year}, Publisher: {Publisher}");
    }
}
class Article : Edition
{
    public string Journal;
    public int Year;

    public Article(string title, string tacgia, string journal, int year) : base(title, tacgia)
    {
        Journal=journal;
        Year=year;
    }

    public override void thongtin()
    {
        Console.WriteLine($"Article: {Title}, Author: {Author}, Journal: {Journal}, Year: {Year}");
    }
}

class OnlineResource:Edition
{
    public string Link;
    public string Abstract;

    public OnlineResource(string title, string tacgia, string link, string abstractt) : base(title, tacgia)
    {
        Link=link;
        Abstract=abstractt;
    }

    public override void thongtin()
    {
        Console.WriteLine($"Online Resource: {Title}, Author:{Author}, Link: {Link}, Abstract: {Abstract}");
    }
}

class Program
{
    static void Main()
    {
        Edition[] ds = new Edition[]
        {
            new Book("Mat biec", "Nguyen Nhat Anh", 2004, "Tuoi tre"),
            new Article("Hoa phuong do", "Thieu nhi", "Tap chi", 2023),
            new OnlineResource("Bao la cai", "Nha bao A", "https://...", "Nham nhi")
        };

        Console.WriteLine("----------Thong tin moi doi tuong------------");
        foreach (var edition in ds)
        {
            edition.thongtin();
        }
        Array.Sort(ds, (x, y) => String.Compare(x.Author, y.Author, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("----------Sap xep danh muc cac an pham theo ten tac gia-----------");
        foreach (var edition in ds)
        {
            edition.thongtin();
        }

        Console.WriteLine("Nhap ten tac gia can tim: ");
        string tentgiacantim = Console.ReadLine();
        Console.WriteLine($"Tac pham cua tac gia {tentgiacantim}:");
        foreach (var edition in ds)
        {
            if (edition.timtgia(tentgiacantim))
            {
                edition.thongtin();
            }
        }
    }
}