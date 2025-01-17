// Xây dựng lớp SoPhuc (Số phức) gồm:
//  Thuộc tính: PhanThuc, PhanAo (Phần thực, Phần ảo)
//  Phương thức:
// • Hàm Khởi tạo không Tham số, Hàm hủy
// • Hàm Nhập, xuất
// • Hàm Cong(), Tru(), Nhan(),Chia()
// Tính Tổng, Hiệu, Tích, Thương 2 số phức A và B rồi in ra kết
// quả trên màn hình

using System;
class SP
{
    private double pThuc;
    private double pAo;
    public double PThuc
    {
        get {return pThuc;}
        set {pThuc=value;}
    }
    public double PAo
    {
        get {return pAo;}
        set {pAo=value;}
    }
    public void nhap()
    {
        Console.Write("Nhap phan thuc:");
        PThuc=double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao:");
        PAo=double.Parse(Console.ReadLine());
    }
    public void xuat()
    {Console.WriteLine("{0}+{1}i",PThuc,PAo);}
    public SP Cong(SP SP2)
    {
        SP kq=new SP();
        kq.PThuc=this.PThuc+SP2.PThuc;
        kq.PAo=this.PAo+SP2.PAo;
        return kq;
    }
    public SP Tru(SP SP2)
    {
        SP kq=new SP();
        kq.PThuc=this.PThuc-SP2.PThuc;
        kq.PAo=this.PAo-SP2.PAo;
        return kq;
    }
    public SP Nhan(SP SP2)
    {
        SP kq=new SP();
        kq.PThuc=this.PThuc*SP2.PThuc-this.PAo*SP2.PAo;
        kq.PAo=this.PThuc*SP2.PAo+this.PAo*SP2.PThuc;
        return kq;
    }
    public SP Chia(SP SP2)
    {
        SP kq=new SP();
        kq.PThuc=(this.PThuc*SP2.PThuc+this.PAo*SP2.PAo)/(SP2.PThuc*SP2.PThuc+SP2.PAo*SP2.PAo);
        kq.PAo=(this.PAo*SP2.PThuc-this.PThuc*SP2.PAo)/(SP2.PThuc*SP2.PThuc+SP2.PAo*SP2.PAo);
        return kq;
    }
}
class Program
{
    static void Main()
    {
        SP spA=new SP();
        SP spB=new SP();

        Console.WriteLine("Nhap so phuc A:");
        spA.nhap();
        Console.WriteLine("Nhap so phuc B:");
        spB.nhap();

        Console.Write("Tong hai so phuc la: ");
        SP Tong=spA.Cong(spB);
        Tong.xuat();

        Console.Write("Hieu hai so phuc la: ");
        SP Hieu=spA.Tru(spB);
        Hieu.xuat();

        Console.Write("Tich hai so phuc la: ");
        SP Tich=spA.Nhan(spB);
        Tich.xuat();

        Console.Write("Thuong hai so phuc la: ");
        SP Thuong=spA.Chia(spB);
        Thuong.xuat();


    }
}


