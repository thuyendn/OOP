// Cửa hàng INOCHI quản lý việc mua hàng của 3 loại khách hàng: 
// - NORMAL CUSTOMERS (Tên khách hàng, Số lượng hàng, Đơn Giá, Chiết khấu) 
// - LOYALCUSTOMERS (Tên khách hàng, Số lượng hàng, Đơn giá, Số năm thân thiết) 
// - SPECIAL CUSTOMERS (Tên khách hàng, Số lượng hàng, Đơn Giá, Ưu đãi) 
// Việc tính số tiền khách hàng phải trả (Cost) được tính như sau: 
// - Normal customers: Cost= Số lượng hàng * đơn giá – Chiết khấu + Thuế VAT (10%) 
// Biết rằng: Chiết khấu = 3% nếu số lượng hàng ≥ 10; Chiết khấu = 5% nếu số lượng hàng ≥ 20
//  - Loyal customers: Cost = (Số lượng hàng * đơn giá) * (100% - % Khuyến mãi) + Thuế VAT (10%)
//   Biết rằng: % Khuyến mãi = MAX(Số năm thân thiết * 5%, 40%) 
//   - Special customers: Cost = (Số lượng hàng * đơn giá) * Ưu đãi + Thuế VAT (10%) 
//   Biết rằng: Ưu đãi ≥ 50% tùy ý (sinh viên tự nhập từ bàn phím)
//    Lập trình trên VSCode, sử dụng Kế thừa và Đa hình để thực hiện các yêu cầu sau:
//     Câu 1. Chọn 1 trong 2 phương pháp sau để định nghĩa lớp trừu tượng CUSTOMER: (2 điểm) 
//     1.1 Định nghĩa lớp trừu tượng CUSTOMER với các thuộc tính chung và phương thức ảo Cost()
//      1.2 Định nghĩa interface ICUSTOMER với phương thức Cost().
//      Định nghĩa lớp trừu tượng CUSTOMER và thực hiện I CUSTOMER 
//      Câu2. Định nghĩa các lớp NORMAL CUSTOMERS, LOYAL CUSTOMERS, SPECIAL CUSTOMERS kế thừa lớp CUSTOMER, 
//      tạo phương thức ghi đè (nếu có). (3 điểm)
//       Câu3. Định nghĩa lớp SALE thực hiện các chức năng sau: 
//       3.1 Nhập các đối tượng khách hàng gồm 7 Normal customers, 5 Loyal customers, 3 Special customers (1 điểm) 
//       3.2. Tính tổng số tiền mỗi khách hàng phải trả và xuất thông tin tất cả khách hàng ra màn hình (2 điểm) 
//       3.3. Tính tổng doanh thu của cửa hàng thu được (2 điểm)
using System;
abstract class customer
{
    public string tenkh;
    public int soluonghang;
    public double dongia;
    public virtual void nhap()
    {
        Console.Write("Nhap ten khach hang: ");
        tenkh=Console.ReadLine();
        Console.Write("Nhap so luong hang: ");
        soluonghang=int.Parse(Console.ReadLine());
        Console.Write("Nhap don gia: ");
        dongia=double.Parse(Console.ReadLine());
    }
    public virtual void xuat()
    {
        Console.WriteLine("----------THONG TIN KHACH HANG----------");
        Console.WriteLine("Ten khach hang: "+tenkh);
        Console.WriteLine("So luong hang: "+soluonghang);
        Console.WriteLine("Don gia: "+dongia);
    }
    public abstract double Cost();
}
interface ICustomer
    {
    double Cost();
    }
class normal :customer
{
    public double chietkhau,cost;
    public override void nhap()
    {
        base.nhap();
        if (soluonghang>=10){chietkhau=0.03;}
        if (soluonghang >=20){chietkhau=0.05;}
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("Chiet khau don hang NORMAL: "+chietkhau);
    }
    public override double Cost()
    {
        double cost = soluonghang * dongia - chietkhau + 0.1 * soluonghang * dongia;
        return cost;
    }
}
class loyal:customer
{
    public double sonamthanthiet;
    public double phantramkm,cost;
    public override void nhap()
    {
        base.nhap();
        Console.Write("Nhap so nam than thiet: ");
        sonamthanthiet=double.Parse(Console.ReadLine());
        phantramkm=Math.Max(sonamthanthiet*0.05,0.4);
    }
    public override void xuat()
    {
        base.xuat();
        Console.WriteLine("So nham than thiet la: "+sonamthanthiet);
        Console.WriteLine("Phan tram khuyen mai la: "+phantramkm);
    }
    public override double Cost()
    {
        double phantramkm = Math.Max(sonamthanthiet * 0.05, 0.4);
        double cost = soluonghang * dongia * (1 - phantramkm / 100) + 0.1 * soluonghang * dongia;
        return cost;
    }
}
class special:customer
{
    public double uudai,cost;
    public virtual void nhap()
    {
        base.nhap();
        Console.Write("Nhap uu dai: ");
        uudai=int.Parse(Console.ReadLine());
    }
    public virtual void xuat()
    {
        base.xuat();
        Console.WriteLine("Uu dai: "+ uudai);
    }
    public override double Cost()
    {
        double cost = soluonghang * dongia * uudai + 0.1 * soluonghang * dongia;
        return cost;
    }
}
class Sale
{
    static void Main()
    {
        customer[] customers = new customer[15];

        for (int i=0; i < 7; i++)
        {
            customers[i]=new normal();
            customers[i].nhap();
        }

        for (int i=7; i < 12; i++)
        {
            customers[i]=new loyal();
            customers[i].nhap();
        }

        for (int i=12; i < 15; i++)
        {
            customers[i]=new special();
            customers[i].nhap();
        }

        double tongdoanhthu=0;

        foreach (customer ctm in customers)
        {
            double cost=ctm.Cost();
            ctm.xuat();
            Console.WriteLine("Tong tien phai tra: " + cost);
            tongdoanhthu+=cost;
        }

        Console.WriteLine("-----------Tong doanh thu cua cua hang: " + tongdoanhthu+"-----------------");
    }
}









