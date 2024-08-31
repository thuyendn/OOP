// using System;

// class KH
// {
//     public string ten;
//     public int giave;

//     public static int doanhthu=0;

//     public virtual int Doanhthu()
//         {
//             Console.WriteLine("tinh doanh thu");
//             return doanhthu;
//     }
//      public virtual void the()
//         {
//             Console.WriteLine("Nguoi mang the");
//         }
// }

// class Nguoilon : KH
// {
//     public string cmnd;
//     public override void the()
//         {
//             Console.WriteLine(ten+" mang the do");
//         }
//     public override int Doanhthu()
//     {
//         giave=250000;
//         doanhthu=doanhthu+giave;
//         return doanhthu;
//     }

// }

// class Treem : KH
// {
//     public double chieucao;

//     public override void the()
//         {
//             Console.WriteLine(ten+" mang the xanh");
//         }

//    public override int Doanhthu()
//         {
//             if (chieucao<1)
//             {
//                 giave=0;
//                 doanhthu=doanhthu+giave;
//             }
//             else 
//             {
//                 giave=130000;
//                 doanhthu=doanhthu+giave;
//             }
//             return doanhthu;
//         }

// }
// class Program
// {
//     static void Main()
//     {
//         Nguoilon nglon=new Nguoilon{ten="Nguyen Van A",cmnd="4567"};
//         nglon.the();
//         nglon.Doanhthu();
//         Treem tem=new Treem{ten="Nguyen Van B",chieucao=1.3};
//         tem.the();
//         tem.Doanhthu();
//         Treem Tem=new Treem{ten="Nguyen Van C",chieucao=0.7};
//         Tem.the();
//         Tem.Doanhthu();
//         Console.WriteLine("Doanh thu:" +KH.doanhthu);
//     }
// }
// BẢI TẬP ÔN TẬP CHƯƠNG KẾ THỪA, ĐA HÌNH
// Bài 1. Công viên Asia Park bán vé vui chơi với giá vé trọn gói là 250.000đ/ người lớn.
// 130.000đ/ trẻ em trên 1m, và miễn phí cho trẻ em dưới Im. Khách đến chơi gồm có người lớn và trẻ em.
// Viết chương trình quản lý thông tin mua vé, gồm các thông tin:
// Đối với khách hàng là người lớn: Tên khách hàng, CMND. Giá vé.
// Đối với khách hàng là trẻ em: Tên khách hàng, chiều cao. Giá vé.
// Sau khi mua vé thì khách hàng sẽ được đeo thẻ như sau: Người lớn sẽ mang thẻ đỏ, trẻ em sẽ được mang thể xanh.
// Tỉnh doanh thu của công viên sau một lượt tham quan.

// using System;
// class KH
// {
//     public string ten;
//     public int giave;
//     public static int doanhthu=0;
//     public virtual int Doanhthu()
//     {
//         Console.WriteLine("Doanh thu bang= ");
//         return doanhthu;
//     }
//     public virtual void The()
//     {
//         Console.WriteLine("Deo the mau");
//     }
// }
// class Nguoilon:KH
// {
//     public string cmnd;
//     public override void The()
//     {
//         Console.WriteLine(ten+"mang the do !!!");
//     }
//     public override int Doanhthu()
//     {
//         giave=250000;
//         doanhthu=doanhthu+giave;
//         return doanhthu;
//     }
// }
// class Treem:KH
// {
//     public double chieucao;
//     public override void The()
//     {
//         Console.WriteLine(ten+"Deo the xanh");
//     }
//     public override int Doanhthu()
//     {
//         if (chieucao<1)
//         {
//             giave=0;
//             doanhthu=doanhthu+giave;
//             return doanhthu;
//         }
//         else
//         {
//             giave=130000;
//             doanhthu=doanhthu+giave;
//             return doanhthu;
//         }
//                     // return doanhthu;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Nguoilon nglon=new Nguoilon{ten="Nguyen Van A",cmnd="22112332"};
//         nglon.Doanhthu();
//         nglon.The();
//         Treem treem1=new Treem{ten="Nguyen Van B",chieucao=1.3};
//         treem1.Doanhthu();
//         treem1.The();
//         Treem treem2=new Treem{ten="Nguyen Van C",chieucao=0.7};
//         treem2.Doanhthu();
//         treem2.The();
//         Console.WriteLine("Doanh thu:" + KH.doanhthu);




//     }
// }






// using System;
// abstract class Dichvu
// {
//     public string Tenkhach;
//     public string Diemnhan;
//     public string Diemden;
//     public double Khoangcach;
//     public double Dongia;
//     public double Giamgia;
//     public virtual void nhap()
//     {
//         Console.Write("Nhap ten KH:");
//         Tenkhach=Console.ReadLine();
//         Console.Write("Nhap diem nhan:");
//         Diemnhan=Console.ReadLine();
//         Console.Write("Nhap diem den:");
//         Diemden=Console.ReadLine();
//         Console.Write("Nhap khoang cach:");
//         Khoangcach=double.Parse(Console.ReadLine());
//         Console.Write("Nhap don gia:");
//         Dongia=double.Parse(Console.ReadLine());
//         Console.Write("Nhap giam gia:");
//         Giamgia=double.Parse(Console.ReadLine());
//     }
//     public abstract double phidv();
    
// }
// class Xemay:Dichvu
// {   private double pdv;

//     public override void nhap()
//     {
//         base.nhap();
//         pdv=Dongia*Khoangcach-Giamgia;
//     }
//     public override double phidv()
//     {
//         return pdv;
//     }
// }
// class Oto: Dichvu
// {
//     private int loaixe;
//     private double heso;
//     private double pdv;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap loai xe:");
//         loaixe=int.Parse(Console.ReadLine());
//         if (loaixe==4)
//         {
//             heso=1;
//         }
//         if (loaixe==7)
//         {
//             heso=2;
//         }    
//         pdv=(Dongia*Khoangcach)*heso-Giamgia;  
//     }
//     public override double phidv()
//     {
//         return pdv;
//     }

// }
// class Giaohang:Dichvu
// {
//     private double giasp;
//     private double pdv;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap gia san pham:");
//         giasp=double.Parse(Console.ReadLine());
//         pdv=(Dongia*Khoangcach)+giasp-Giamgia;
//     }
//     public override double phidv()
//     {
//         return pdv;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("\n------ MENU ------");
//             Console.WriteLine("0. Dừng");
//             Console.WriteLine("1. In thông tin và chi phí dịch vụ của xe máy");
//             Console.WriteLine("2. In thông tin và chi phí dịch vụ của xe ô tô");
//             Console.WriteLine("3. In thông tin và chi phí dịch vụ của giao hàng");

//             Console.Write("Nhập lựa chọn: ");
//             int choice = int.Parse(Console.ReadLine());
            
//             if (choice==0)
//             {
//                 Console.WriteLine("Kết thúc dịch vụ. Tạm biệt!");
//                 break;
//             }
//             Dichvu dichvu;
//             switch (choice)
//             {
//                 case 1: 
//                     dichvu=new Xemay();
//                     break;
//                 case 2: 
//                     dichvu=new Oto();
//                     break;
//                 case 3: 
//                     dichvu=new Giaohang();
//                     break;
//                 default:
//                     Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
//                     continue;

//             }
//             dichvu.nhap();
//             Console.WriteLine("Chi phi dich vu="+dichvu.phidv());
//         }
//     }
// }



// using System;
// using System.ComponentModel.Design;
// using System.Diagnostics.Contracts;
// class Basic
// {
//     public string ID;
//     public double Area;
//     public int Floor;
//     public double Gia;
//     public Basic(string id, double area, int floor, double gia)
//     {
//         ID=id;
//         Area=area;
//         Floor=floor;
//         Gia=gia; 
//     }
//     public void Cost(){
//         Gia=10*Area;
//     }
//     public void Xuat()
//     {
//         Console.WriteLine($"ID: {ID}; dien tich: {Area}; tang: {Floor}; Gia: {Gia}");
//     }
    
// }
// class Condo:Basic
// {
//     private string View;
//     public Condo(string id, double area, int floor, double gia, string view):base(id,area,floor,gia)
//     {
//         View=view;
//     }
//     public new void Cost()
//     {   
//         Gia=20*Area;
//         if (View == "Ho boi" ) {Gia*=1.1;}
//         if (View == "Bien" ) {Gia*=1.4;}
//         if (View == "Thanh phi" ) {Gia*=1.2;}
//         if (View == "Khác" ) {Gia*=1.0;}
//     }
//     public new void Xuat()
//     {
//          Console.WriteLine($"ID: {ID}; dien tich: {Area}; tang: {Floor}; Gia: {Gia}");
//     }
// }
// class Program
// {
//     static void Main()
//     {double maxx; string index;
//         Basic b1 = new Basic("1",3,2,0);b1.Cost();b1.Xuat();
//         Basic b2 = new Basic("2",2.5,3,0);b2.Cost();b2.Xuat();
//         Basic b3 = new Basic("3",1.5,4,0);b3.Cost();b3.Xuat();
//         Condo c1 = new Condo("4",3.5,2,0,"Bien");c1.Cost();c1.Xuat();
//         Condo c2 = new Condo("5",4,3,0,"Ho boi");c2.Cost();c2.Xuat();
//         Condo c3 = new Condo("6",3.2,4,0,"Thanh pho");c3.Cost();c3.Xuat();
//         Condo c4 = new Condo("7",3,2,0,"Bien");c4.Cost();c4.Xuat();
//         maxx=b1.Gia; index=b1.ID;
//         if (maxx<b2.Gia){maxx=b2.Gia;index=b2.ID;} 
//         if (maxx<b3.Gia){maxx=b3.Gia;index=b3.ID;}
//         if (maxx<c1.Gia){maxx=c1.Gia;index=c1.ID;}
//         if (maxx<c2.Gia){maxx=c2.Gia;index=c2.ID;}
//         if (maxx<c3.Gia){maxx=c3.Gia;index=c3.ID;}
//         Console.WriteLine("Can ho:"+index+"Co gia cao nhat la:"+maxx);

//     }

// }

// using System;
// abstract class DICHVU
// {
//     public string tenkhach,diemnhan, diemden;
//     public float khoangcach,dongia,giamgia;
//     public virtual void nhap()
//     {
//         Console.Write("Nhap ten khach: ");tenkhach = Console.ReadLine();
//         Console.Write("Nhap diem nhan: ");diemnhan = Console.ReadLine();
//         Console.Write("Nhap diem den: ");diemden = Console.ReadLine();
//         Console.Write("Nhap khoang cach: ");khoangcach = float.Parse(Console.ReadLine());
//         Console.Write("Nhap don gia: ");dongia = float.Parse(Console.ReadLine());
//         Console.Write("Nhap giam gia: ");giamgia = float.Parse(Console.ReadLine());
//     }
//     public virtual void xuat()
//     {
//         Console.WriteLine("---THONG TIN KHACH HANG---");
//         Console.WriteLine($"Ten khach: {tenkhach}");
//         Console.WriteLine($"Diem nhan: {diemnhan}");
//         Console.WriteLine($"Diem den: {diemden}");
//         Console.WriteLine($"Khoang cach: {khoangcach}");
//         Console.WriteLine($"Don gia: {dongia}");
//         Console.WriteLine($"Giam gia: {giamgia}");
//     }
//     public virtual void phidichvu(){}
// }
// class xemay : DICHVU
// {
//     public float pdv;
//     public override void nhap()
//     {
//         base.nhap();
//     }
//     public override void xuat()
//     {
//         base.xuat();
//     }
//     public override void phidichvu()
//     {
//         pdv = (dongia*khoangcach) - giamgia;
//         Console.WriteLine($"Phi dich vu cua xe may la: {pdv}");
//     }
// }
// class oto : DICHVU
// {
//     public float pdv;public int loaixe,hesoloaixe;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap loai xe: ");
//         loaixe = int.Parse(Console.ReadLine());
//         if (loaixe == 4) {hesoloaixe = 1;}
//         else {hesoloaixe = 2;}
//     }
//     public override void xuat()
//     {
//         base.xuat();
//         Console.WriteLine($"Loai xe: {loaixe}");
//     }
//     public override void phidichvu()
//     {
//         pdv = (dongia*khoangcach*hesoloaixe) - giamgia;
//         Console.WriteLine($"Phi dich vu cua o to la: {pdv}");
//     }
// }
// class giaohang : DICHVU
// {
//     public float pdv,giasp;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap gia san pham: ");
//         giasp = float.Parse(Console.ReadLine());
//     }
//     public override void xuat()
//     {
//         base.xuat();
//         Console.WriteLine($"Gia san pham: {giasp}");
//     }
//     public override void phidichvu()
//     {
//         pdv = (dongia*khoangcach) + giasp - giamgia;
//         Console.WriteLine($"Phi dich vu cua giao hang la: {pdv}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("------------MENU-----------");
//             Console.WriteLine("BAM 0: Dung");
//             Console.WriteLine("BAM 1: In ra thong tin va chi phi dich vu cua xe may");
//             Console.WriteLine("BAM 2: In ra thong tin va chi phi dich vu cua xe o to");
//             Console.WriteLine("BAM 3: In ra thong tin va chi phi dich vu cua xe giao hang");
//             Console.Write("Vui long chon noi dung thuc hien: ");
//             int need = int.Parse(Console.ReadLine());
//             if (need == 0)
//             {
//                 Console.WriteLine("---KET THUC CHUONG TRINH---");
//                 break;
//             }
//             else if (need == 1)
//             {
//                 xemay a = new xemay();
//                 a.nhap();
//                 a.xuat();
//                 a.phidichvu();
//             }
//             else if (need == 2)
//             {
//                 oto b = new oto();
//                 b.nhap();
//                 b.xuat();
//                 b.phidichvu();
//             }
//             else if (need == 3)
//             {
//                 giaohang c = new giaohang();
//                 c.nhap();
//                 c.xuat();
//                 c.phidichvu();
//             }
//         }
//     }
// }




// using System;
// using System.ComponentModel;
// abstract class Dichvu
// {
//     public string tenkhach, diemnhan, diemden;
//     public double khoangcach, dongia, giamgia;
//     public virtual void nhap()
//     {
//         Console.WriteLine("----------Nhap thong tin nguoi dung----------");
//         Console.Write("Nhap ten khach:"); tenkhach=Console.ReadLine();
//         Console.Write("Nhap diem nhan: "); diemnhan=Console.ReadLine();
//         Console.Write("Nhap diem den: ");diemden=Console.ReadLine();
//         Console.Write("Nhap khoang cach: "); khoangcach=double.Parse(Console.ReadLine());
//         Console.Write("Nhap don gia: ");dongia=double.Parse(Console.ReadLine());
//         Console.Write("Nhap giam gia: ");giamgia=double.Parse(Console.ReadLine());
//     }
//     public virtual void xuat()
//     {
//         Console.WriteLine("----------Thong tin nguoi dung----------");
//         Console.WriteLine("Ten khach hang la: "+tenkhach);
//         Console.WriteLine("Diem nhan: "+ diemnhan);
//         Console.WriteLine("Diem den: "+diemden);
//         Console.WriteLine("Khoang cach: "+khoangcach);
//         Console.WriteLine("Don gia: "+dongia);
//         Console.WriteLine("Giam gia: "+giamgia);

//     }
//     public virtual void phidichvu(){}

// }
// class xemay:Dichvu
// {
//     public double pdv;
//     public override void nhap()
//     {
//         base.nhap();
//     }
//     public override void xuat()
//     {
//         base.xuat();
//     }
//     public override void phidichvu()
//     {
//         pdv=dongia*khoangcach-giamgia;
//         Console.WriteLine("Phi dich vu xe may la: "+pdv);
//     }
// }
// class oto:Dichvu
// {
//     public int loaixe,hesoloaixe;
//     public double pdv;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap loai xe: ");loaixe=int.Parse(Console.ReadLine());
//         if (loaixe==4) {hesoloaixe=1;}
//         else if (loaixe==7) {hesoloaixe=2;}
//         else {Console.WriteLine("Nhap khong chinh xac.Nhap lai!!!!!!");} 
//     }
//     public override void xuat()
//     {
//         base.xuat();
//         Console.WriteLine("Loai xe: "+loaixe+" ,He so loai xe: "+hesoloaixe);
//     }
//     public override void phidichvu()
//     {
//         pdv=(dongia*khoangcach)*hesoloaixe-giamgia;
//         Console.WriteLine("Phi dich vu xe oto la: "+pdv);

//     }
// }
// class giaohang:Dichvu
// {
//     public double giasp, pdv;
//     public override void nhap()
//     {
//         base.nhap();
//         Console.Write("Nhap gia san pham: ");giasp=double.Parse(Console.ReadLine());
//     }
//     public override void xuat()
//     {
//         base.xuat();
//         Console.WriteLine("Gia san pham la: "+giasp);
//     }
//     public override void phidichvu()
//     {
//         pdv=(dongia*khoangcach)+giasp-giamgia;
//         Console.WriteLine("Phi dich vu giao hang la: "+pdv);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("--------------MENU--------------");
//             Console.WriteLine("Bam 0: Dung ");
//             Console.WriteLine("Bam 1: In ra thong tin va chi phi dich vu xe may");
//             Console.WriteLine("Bam 2: In ra thong tin va chi phi dich vu xe oto");
//             Console.WriteLine("Bam 3: In ra thong tin va chi phi dich vu giao hang");
//             Console.Write("Nhap lua chon: "); int choice=int.Parse(Console.ReadLine());
//             if (choice==0) {Console.WriteLine("Ket thuc chuong trinh !!!"); break;}
//             switch (choice)
//             {
//                 case 1:
//                     xemay a=new xemay();
//                     a.nhap();
//                     a.xuat();
//                     a.phidichvu();
//                     break;
//                 case 2:
//                     oto b=new oto();
//                     b.nhap();
//                     b.xuat();
//                     b.phidichvu();
//                     break;
//                 case 3:
//                  giaohang c=new giaohang();
//                  c.nhap();
//                  c.xuat();
//                  c.phidichvu();
//                  break;
//                 default:
//                     Console.WriteLine("Khong hop le !!! Nhap lai !!!!");
//                     continue;

//             }   
//         }
//     }
// }
// BẢI TẬP ÔN TẬP CHƯƠNG KẾ THỪA, ĐA HÌNH
// Bài 1. Công viên Asia Park bán vé vui chơi với giá vé trọn gói là 250.000đ/ người lớn.
// 130.000đ/ trẻ em trên 1m, và miễn phí cho trẻ em dưới Im. Khách đến chơi gồm có người lớn và trẻ em.
// Viết chương trình quản lý thông tin mua vé, gồm các thông tin:
// Đối với khách hàng là người lớn: Tên khách hàng, CMND. Giá vé.
// Đối với khách hàng là trẻ em: Tên khách hàng, chiều cao. Giá vé.
// Sau khi mua vé thì khách hàng sẽ được đeo thẻ như sau: Người lớn sẽ mang thẻ đỏ, trẻ em sẽ được mang thể xanh.
// Tỉnh doanh thu của công viên sau một lượt tham quan.
// using System;
// class KH
// {
//     public string Tenkh;
//     public double Giave;
//     public static double doanhthu=0;
//     public virtual void the()
//     {Console.WriteLine("Nhap ten KH: "+Tenkh );
//     }
//     public virtual void Dthu()
//     {

//     }
    

// }
// class Nguoilon:KH{
//     public string cmnd;
//     public override void the()
//     {
//         base.the();
//         Console.WriteLine("Nhap cmnd: "+cmnd);
//         Console.WriteLine("Mang the do");
//     }
//     public override void Dthu()
//     {
//         doanhthu=doanhthu+250000;
//     }
// }
// class Treem:KH
// {
//     public double chieucao;
//     public override void the()
//     {
//         base.the();
//         Console.WriteLine("Mang the xanh ");
//     }
//     public override void Dthu()
//     {
//         Console.WriteLine("Nhap chieu cao: "+chieucao);
//         if (chieucao>1) {doanhthu=doanhthu+130000;}
//         else {doanhthu=doanhthu+0;}
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Nguoilon l1=new Nguoilon{Tenkh="Nguyen Van A", cmnd="01389938"};
//         l1.the();
//         l1.Dthu();
//         Treem e1=new Treem{Tenkh="Nguyen Van B", chieucao=1.5};
//         e1.the();
//         e1.Dthu();
//         Treem e2=new Treem{Tenkh="Nguyen Van C", chieucao=0.7};
//         e2.the();
//         e2.Dthu();
//         Console.WriteLine("Tong doanh thu: "+ KH.doanhthu);


//     }
// }

// //         Nguoilon nglon=new Nguoilon{ten="Nguyen Van A",cmnd="22112332"};
// //         nglon.Doanhthu();
// //         nglon.The();
// //         Treem treem1=new Treem{ten="Nguyen Van B",chieucao=1.3};
// //         treem1.Doanhthu();
// //         treem1.The();
// //         Treem treem2=new Treem{ten="Nguyen Van C",chieucao=0.7};
// //         treem2.Doanhthu();
// //         treem2.The();
// //         Console.WriteLine("Doanh thu:" + KH.doanhthu);

using System;
using System.ComponentModel.DataAnnotations;
class Basic
{
    public string Id;
    public double Area, Price;
    public int Floor;
    public virtual void nhap()
    {
        Console.Write("Nhap Id: ");Id=Console.ReadLine();
        Console.Write("Nhap dien tich: "); Area=double.Parse(Console.ReadLine());
        Console.Write("Nhap tang:");Floor=int.Parse(Console.ReadLine());
    }
    public virtual void Cost()
    {
        Price=10*Area;
        Console.WriteLine("Gia can ho co ban: "+Price);
    }
}
class Condo:Basic
{
    public string View;
    public override void nhap()
    {
        base.nhap();
        Console.Write("Nhap huong: ");View=Console.ReadLine();
    }
    public virtual void Cost()
    {
        Price=20*Area;
        if (View=="Bien") {Price*=1.4;}
        if (View=="Ho boi") {Price*=1.1;}
        if (View=="Thanh pho") {Price*=1.2;}
        if (View=="Khac") {Price*=1.0;}
        Console.WriteLine("Gia can ho cao cap: "+Price);
    }
}
class Program
{
    static void Main()
    {
        Basic b1=new Basic();
        b1.nhap();
        b1.Cost();
        Basic b2=new Basic();
        b2.nhap();
        b2.Cost();
        Basic b3=new Basic();
        b3.nhap();
        b3.Cost();
        Condo c1=new Condo();
        c1.nhap();
        c1.Cost();
        Condo c2=new Condo();
        c2.nhap();
        c2.Cost();
        Condo c3=new Condo();
        c3.nhap();
        c3.Cost();
        double max=0;
        max=b1.Cost(); 


    }
}