using System;

class Organization
{
    public string name;
    public string country;
    public string city;
    public string address;
    public string telephone;

    public Organization()
    {   
        name="";
        country="";
        city="";
        address="";
        telephone="";
    }

    public void nhap()
    {
        Console.Write("Nhap Ten Doanh nghiep: ");
        name=Console.ReadLine();
        Console.Write("Nhap Quoc gia: ");
        country=Console.ReadLine();
        Console.Write("Nhap Thanh pho: ");
        city=Console.ReadLine();
        Console.Write("Nhap Dia chi: ");
        address=Console.ReadLine();
        bool sdt=false;
        while (!sdt)
        {
            Console.Write("Nhap Sdt: ");
            telephone=Console.ReadLine();
            sdt=IsNumeric(telephone) || telephone.Length == 10;
            if (!sdt)
            {
                Console.WriteLine("Sdt khong hop le !");
            }
        }
    }
    private bool IsNumeric(string input)
    {
        foreach (char x in input)
        {
            if (!Char.IsNumber(x))
            {
                return false;
            }
        }
        return true;
    }
    public bool ktra()
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(country) ||
            string.IsNullOrWhiteSpace(city) ||
            string.IsNullOrWhiteSpace(address) ||
            !IsNumeric(telephone) ||
            telephone.Length!=10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void xuat()
    {
        if (!ktra())
        {
            Console.WriteLine("Cong ty: {0}, quoc gia: {1}, thanh pho: {2}, dia chi: {3}, sdt: {4}", name, country, city, address, telephone);
        }
        else
        {
            Console.WriteLine("Nhap thong tin loi !");
        }
    }
    public static void Main()
    {
        Organization tochuc=new Organization();
        tochuc.nhap();
        tochuc.xuat();
    }
}

