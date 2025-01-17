// using System;
// class Program
// {
//     static void Main()
//     {
//         List<PhongThue> dsphong = nhapdsphong();
//         Console.WriteLine("Danh sach thong tin thue phong:");
//         foreach (var phong in dsphong)
//         {
//             phong.HienThi();
//         }

//         double tongtienStandard = 0;
//         double tongtienVip = 0;
//         foreach (var phong in dsphong)
//         {
//             if (phong is PhongStandard)
//             {
//                 tongtienStandard += phong.TinhChiPhi();
//             }
//             else if (phong is PhongVip)
//             {
//                 tongtienVip += phong.TinhChiPhi();
//             }
//         }
//         Console.WriteLine("Tong tien cho thue phong Standard: " + tongtienStandard);
//         Console.WriteLine("Tong tien cho thue phong Vip: " + tongtienVip);

//         Console.WriteLine("Thong tin thue phong Standard:");
//         foreach (var phong in dsphong)
//         {
//             if (phong is PhongStandard)
//             {
//                 phong.HienThi();
//             }
//         }

//         double tongtienLuxury = 0;
//         foreach (var phong in dsphong)
//         {
//             if (phong is PhongVip phongvip && phongvip.LoaiPhong == LoaiPhongVip.Luxury)
//             {
//                 tongtienLuxury += phong.TinhChiPhi();
//             }
//         }
//         Console.WriteLine("Tong tien cho thue phong Luxury:" + tongtienLuxury);
//     }

//     static List<PhongThue> nhapdsphong()
//     {
//         List<PhongThue> dsphong = new List<PhongThue>();
//         Console.Write("Nhap so luong khach hang: ");
//         int slKH = int.Parse(Console.ReadLine());
//         for (int i = 0; i < slKH; i++)
//         {
//             Console.Write("Nhap thong tin khach hang: "+(i + 1));
//             Console.Write("Chon loai phong (Standard/VIP): ");
//             string loaiPhong = Console.ReadLine();

//             if (loaiPhong.ToLower() == "standard")
//             {
//                 dsphong.Add(NhapStandard());
//             }
//             else if (loaiPhong.ToLower() == "vip")
//             {
//                 dsphong.Add(NhapVip());
//             }
//             else
//             {
//                 Console.WriteLine("Loai phong khong hop le. Vui long chon lai!!!!!!!");
//                 i--; 
//             }
//         }
//         return dsphong;
//     }

//     static PhongStandard NhapStandard()
//     {
//         Console.Write("Nhap ten KH Standard: ");
//         string tenKHStandard = Console.ReadLine();

//         Console.Write("Nhap so CMND Standard: ");
//         string soCMNDStandard = Console.ReadLine();

//         Console.Write("Nhap so ngay thue Standard: ");
//         int soNgayThueStandard = int.Parse(Console.ReadLine());

//         return new PhongStandard(tenKHStandard, soCMNDStandard, soNgayThueStandard);
//     }

//     static PhongVip NhapVip()
//     {
//         Console.Write("Nhap ten KH VIP: ");
//         string tenKHVip = Console.ReadLine();

//         Console.Write("Nhap so CMND VIP: ");
//         string soCMNDVip = Console.ReadLine();

//         Console.Write("Nhap so ngay thue VIP: ");
//         int soNgayThueVip = int.Parse(Console.ReadLine());

//         Console.Write("Chon loai phong vip VIP (Luxury/President): ");
//         string loaiPhongVip = Console.ReadLine();

//         return new PhongVip(tenKHVip, soCMNDVip, soNgayThueVip, (LoaiPhongVip)Enum.Parse(typeof(LoaiPhongVip), loaiPhongVip, true));
//     }

//     abstract class PhongThue
//     {
//         public string TenKhachHang { get; set; }
//         public string SoCMND { get; set; }
//         public int SoNgayThue { get; set; }

//         public PhongThue(string tenKhachHang, string soCMND, int soNgayThue)
//         {
//             TenKhachHang = tenKhachHang;
//             SoCMND = soCMND;
//             SoNgayThue = soNgayThue;
//         }

//         public abstract double TinhChiPhi();

//         public virtual void HienThi()
//         {
//             Console.WriteLine("Khach hang: " + TenKhachHang, "CMND: " +SoCMND, "So ngay thue: "+SoNgayThue);
//         }
//     }

//     class PhongStandard : PhongThue
//     {
//         public PhongStandard(string tenKhachHang, string soCMND, int soNgayThue)
//             : base(tenKhachHang, soCMND, soNgayThue)
//         {
//         }

//         public override double TinhChiPhi()
//         {
//             if (SoNgayThue <= 5)
//             {
//                 return 500 * SoNgayThue;
//             }
//             else
//             {
//                 return 400 * SoNgayThue;
//             }
//         }

//         public override void HienThi()
//         {
//             base.HienThi();
//             Console.WriteLine("Loai phong: Standard, Chi phi: "+TinhChiPhi());
//         }
//     }

//     enum LoaiPhongVip  //liệt kê loại phòng vip có 2 giá trị cố định, có thể chọn gtri từ Loaiphongvip cho Loaiphong
//     {
//         Luxury,
//         President
//     }

//     class PhongVip : PhongThue
//     {
//         public LoaiPhongVip LoaiPhong { get; set; }

//         public PhongVip(string tenKhachHang, string soCMND, int soNgayThue, LoaiPhongVip loaiPhong)
//             : base(tenKhachHang, soCMND, soNgayThue)
//         {
//             LoaiPhong = loaiPhong;
//         }

//         public override double TinhChiPhi()
//         {
//             if (SoNgayThue <= 5)
//             {
//                 return LoaiPhong == LoaiPhongVip.Luxury ? 1100 * SoNgayThue : 1300 * SoNgayThue;
//             }
//             else
//             {
//                 return 1000 * SoNgayThue;
//             }
//         }

//         public override void HienThi()
//         {
//             base.HienThi();
//             Console.WriteLine("Loai phong: "+LoaiPhong,"Chi phí: " +TinhChiPhi());
//         }
//     }
// }






















abstract class RoomForRent
{
    public string tenKH,CMND;
    public int songay;
    public RoomForRent(string tenKH,string CMND,int songay)
    {
        this.tenKH = tenKH;
        this.CMND = CMND;
        this.songay = songay;
    }
    public abstract int Cost();
}
class Standard : RoomForRent
{
    public Standard(string ten,string cmnd,int songaythue) : base(ten,cmnd,songaythue){}
    public override int Cost()
    {
        if (songay<=5) {return songay*500;}
        else {return 400*songay;}
    }
}
class VIP : RoomForRent
{
    public enum RoomType
    {
        Luxury,
        President
    }
    public RoomType loai;
    public VIP(string ten,string cmnd,int songaythue,RoomType loai ) : base(ten,cmnd,songaythue)
    {
        this.loai = loai;
    }
    public override int Cost()
    {
        if (songay<=5)
        {
            if (loai==RoomType.Luxury) {return songay*1100;}
            else {return songay*1300;}
        }
        else {return songay*1000;}
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<RoomForRent> ds = new List<RoomForRent>();
        ds.Add(new Standard("A","1",2));
        ds.Add(new VIP("B","2",2,VIP.RoomType.Luxury));
        ds.Add(new VIP("C","3",6,VIP.RoomType.President));
        ds.Add(new Standard("D","4",6));
        ds.Add(new VIP("E","5",6,VIP.RoomType.Luxury));
        ds.Add(new VIP("F","6",2,VIP.RoomType.President));
        int total = 0,total_L = 0;
        foreach (var i in ds)
        {
            Console.WriteLine($"Ten: {i.tenKH}; CMND: {i.CMND}; So ngay thue: {i.songay}");
            total += i.Cost();
        }
        Console.WriteLine($"Tong tien phong Standard và VIP: {total}");
        foreach (var i in ds)
        {
            if (i is Standard)
            {
                Console.WriteLine($"Ten: {i.tenKH}; CMND: {i.CMND}; So ngay thue: {i.songay}; tien thue: {i.Cost()}");
            }
            if (i is VIP vip && vip.loai==VIP.RoomType.Luxury)
            {
                total_L += i.Cost();
            }
        }
        Console.WriteLine($"Tong tien phong Luxury: {total_L}");
    }


// using System;
// class Phong
// {
//     public string ten,cmnd;
//     public int songaythue;
//     public Phong(string ten, string cmnd, int songaythue)
//     {
//         this.ten=ten;
//         this.cmnd=cmnd;
//         this.songaythue=songaythue;
//     }
//     public virtual int Cost(){return 0;}
// }
// class Standard:Phong
// {
//     public Standard(string ten, string cmnd, int songaythue):base(ten,cmnd,songaythue){}
//     public override int Cost()
//     {
//         if (songathue<5) {return songaythue*500;}
//         else {return songaythue*400;}
//     }
// }
// class VIP:Phong
// {
//     public enum Loai
//     {
//         Luxury,President
//     }
//     public Loai loai;
//     public VIP(string ten, string cmnd, int songaythue,string loai):base(ten,cmnd,songaythue)
//     {
//         this.loai=loai;
//     }
//     public override int Cost()
//     {
//         if (songaythue<5)
//         {
//             if (loai==Loai.Luxury){ return songaythue*1100;}
//             else {return songaythue*1300;}
//         }
//         else{return songaythue*1000;}
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         List<Phong> ds=new List<Phong>();
//         ds.Add(new Standard("A","1",2));
//         ds.Add(new VIP("B","2",2,VIP.Loai.Luxury));
//         ds.Add(new VIP("C","3",6,VIP.Loai.President));
//         ds.Add(new Standard("D","4",6));
//         ds.Add(new VIP("E","5",6,VIP.Loai.Luxury));
//         ds.Add(new VIP("F","6",2,VIP.Loai.President));
        
//         int tong=0;
//         foreach (var i in ds)
//         {
//             Console.WriteLine("Ten"+i.ten+" ,cmnd: "+i.cmnd+" ,so ngay thue: "+i.songaythue+" ,tien thue: "+ i.Cost());
//             tong+=i.Cost();
//         }
//         Console.WriteLine("Tong tien phong: "+tong);
//         int tongL=0;
//         foreach (var i in ds)
//         {
//             if (i is Standard){Console.WriteLine("Ten: "+i.ten+" ,cmnd: "+i.cmnd+" ,so ngay thue: "+i.songaythue+ " ,tien thue: "+ i.Cost());}
//             if (i is VIP vip && vip.loai=VIP.Loai.Luxury){tongL+=i.Cost();}
//         }
//         Console.WriteLine("Tong tien phong Luxury: "+tongL);

//     }
// }


// //         foreach (var i in ds)
// //         {
// //             if (i is Standard)
// //             {
// //                 Console.WriteLine($"Ten: {i.tenKH}; CMND: {i.CMND}; So ngay thue: {i.songay}; tien thue: {i.Cost()}");
// //             }
// //             if (i is VIP vip && vip.loai==VIP.RoomType.Luxury)
// //             {
// //                 total_L += i.Cost();
// //             }
// //         }
// //         Console.WriteLine($"Tong tien phong Luxury: {total_L}");
// //     }





using System;
abstract class Phong
{
    public string ten,cmnd;
    public int songaythue;
    public Phong(string ten, string cmnd, int songaythue)
    {
        this.ten=ten;
        this.cmnd=cmnd;
        this.songaythue=songaythue;
    }
    public abstract int Cost();
}
class Standard:Phong
{
    public Standard(string ten, string cmnd, int songaythue):base(ten,cmnd,songaythue){}
    public override int Cost()
    {
        if (songaythue<=5) {return songaythue*500;}
        else {return songaythue*400;}
    }
}
class VIP:Phong
{
    public enum Loai
    {
        Luxury,President
    }
    public Loai loai;
    public VIP(string ten, string cmnd, int songaythue,VIP.Loai loai):base(ten,cmnd,songaythue)
    {
        this.loai=loai;
    }
    public override int Cost()
    {
        if (songaythue<5)
        {
            if (loai==VIP.Loai.Luxury){ return songaythue*1100;}
            else {return songaythue*1300;}
        }
        else{return songaythue*1000;}
    }
}
class Program
{
    static void Main()
    {
        List<Phong> ds=new List<Phong>();
        ds.Add(new Standard("A","1",2));
        ds.Add(new VIP("B","2",2,VIP.Loai.Luxury));
        ds.Add(new VIP("C","3",6,VIP.Loai.President));
        ds.Add(new Standard("D","4",6));
        ds.Add(new VIP("E","5",6,VIP.Loai.Luxury));
        ds.Add(new VIP("F","6",2,VIP.Loai.President));
        
        int tong=0;
        foreach (var i in ds)
        {
            Console.WriteLine("Ten"+i.ten+" ,cmnd: "+i.cmnd+" ,so ngay thue: "+i.songaythue);
            tong+=i.Cost();
        }
        Console.WriteLine("Tong tien phong: "+tong);
        int tongL=0;
        foreach (var i in ds)
        {
            if (i is Standard){Console.WriteLine("Ten: "+i.ten+" ,cmnd: "+i.cmnd+" ,so ngay thue: "+i.songaythue+ " ,tien thue: "+ i.Cost());}
            if (i is VIP vip && vip.loai==VIP.Loai.Luxury){tongL+=i.Cost();}
        }
        Console.WriteLine("Tong tien phong Luxury: "+tongL);

    }
}