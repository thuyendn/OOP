// Bài 5: Xây dựng lớp Doanhnghiep gồm các thuộc tính: TenDN,
// MST, Diachi lần lượt là Tên doanh nghiệp, Mã số thuế, Địa chỉ
// của doanh nghiệp đó.
// Từ đó xây dựng lớp DanhsachDN (Danh sách doanh nghiệp)
// với các phương thức:
//  Nhập danh sách doanh nghiệp
//  Xuất danh sách doanh nghiệp
//  Tìm mã số thuế theo tên doanh nghiệp (chỉ mục )

//  Tìm tên doanh nghiệp và địa chỉ doanh nghiệp theo mã số
// thuế (chỉ mục )



using System;
class Doanhnghiep
{
    public string ten;
    public string mst;
    public string diachi;
}
class DanhsachDN
{
    private Doanhnghiep[] ds;
    public void nhapds()
    {
        Console.Write("Nhap so luong DN: ");
        int n=Convert.ToInt32(Console.ReadLine());

        ds=new Doanhnghiep[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("Nhap thong tin doanh nghiep {0}:",i+1);
            ds[i]=new Doanhnghiep();
            Console.Write("Ten doanh nghiep:");
            ds[i].ten=Console.ReadLine();
            Console.Write("Ma so thue:");
            ds[i].mst=Console.ReadLine();
            Console.Write("Dia chi:");
            ds[i].diachi=Console.ReadLine();
        }
    }
    public void xuat()
    {
        Console.WriteLine("Danh sach doanh nghiep:");
        for (int i=0;i<ds.Length;i++)
        {
            Console.WriteLine("Doanh nghiep {0}:",i+1);
            Console.WriteLine("Ten: {0}, Ma so thue: {1}. Dia chi: {2}", ds[i].ten,ds[i].mst, ds[i].diachi);
        }
    }
    public void timMST(string tenDN)
    {
        for (int i=0;i<ds.Length;i++)
        {
            if (ds[i].ten==tenDN)
            {
                Console.WriteLine("Ma so thue cua doanh nghiep {0} la: {1}", tenDN,ds[i].mst);
                return;
            }
        }
        Console.WriteLine("Khong tim hay doanh nghiep tren !!!");
    }
    public void timTenvaDC(string MST)
    {
        for (int i=0;i<ds.Length;i++)
        {
            if (ds[i].mst==MST)
            {
                Console.WriteLine("Doanh nghiep co MST {0} co ten {1}, dia chi {2}.",MST,ds[i].ten,ds[i].diachi);
                return; 
            }
        }
        Console.WriteLine("Khong tim hay doanh nghiep co MST tren !!!");
    }
}
class Program
{
    static void Main()
    {
        DanhsachDN dsDN=new DanhsachDN();
        dsDN.nhapds();
        dsDN.xuat();
        Console.Write("Nhap ten DN can tim:");
        string tencantim=Console.ReadLine();
        dsDN.timMST(tencantim);
        Console.Write("Nhap ma so thue can tim: ");
        string mstcantim = Console.ReadLine();
        dsDN.timTenvaDC(mstcantim);      
    }
}




