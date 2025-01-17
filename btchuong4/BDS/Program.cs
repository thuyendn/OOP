﻿// using System;
// // using System.Globalization;

// namespace BDS
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {   
//             Console.OutputEncoding=System.Text.Encoding.Unicode;
//             Console.InputEncoding=System.Text.Encoding.Unicode;
//             DanhsachBDS ds1=new DanhsachBDS();
//             ds1.Nhap();
//             Console.WriteLine("-----------------------------------------------");
//             Console.WriteLine("| CHỨC NĂNG CHÍNH CỦA CHƯƠNG TRÌNH QUẢN LÝ:    |");
//             Console.WriteLine("| BẤM 1: THÊM MỚI DANH SÁCH                    |");
//             Console.WriteLine("| BẤM 2: SỬA THÔNG TIN                         |");
//             Console.WriteLine("| BẤM 3: XOÁ THÔNG TIN                         |");
//             Console.WriteLine("| BẤM 4: XUẤT DANH SÁCH                        |");
//             Console.WriteLine("| BẤM 5: TÌM THEO TÊN                          |");
//             Console.WriteLine("| BẤM 6: TÌM THEO HƯỚNG                        |");
//             Console.WriteLine("| BẤM 7: TÌM THEO GIÁ                          |");
//             Console.WriteLine("| BẤM 0: EXIT                                  |");
//             Console.WriteLine("-----------------------------------------------");
//             while (true)
//             {
//                 Console.Write(" Nhập chức năng:");
//                 int k=Convert.ToInt32(Console.ReadLine());
//                 if(k==1)
//                 {
//                     ds1.them();
//                 }
//                 else if (k==2)
//                 {
//                     ds1.sua();
//                 }
//                 else if(k==3)
//                 {
//                     ds1.xoa();
//                 }
//                 else if(k==4)
//                 {
//                     ds1.xuat();
//                 }
//                 else if(k==5)
//                 {
//                     ds1.TimThongTinBDSTheoTEN();
//                 }
//                 else if(k==6)
//                 {
//                     ds1.TimThongTinBDSTheoHuong();;
//                 }
//                 else if(k==7)
//                 {
//                     ds1.TimThongTinBDSTheoGia();;
//                 }
//                 else if(k==0)
//                 {
//                     Console.Write("Chương trình quản lý kết thúc");
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Yêu cầu nhập lại chức năng từ 0 --> 7");
//                 }             
//             }
                             
//         }
//     }
//     class Batdongsan
//     {
//         public string MaBDS,TenBDS,Huong,Diachi;
//         public double Dientich,Giaban;
//     }
//     class DanhsachBDS
//     {
//         public List<Batdongsan>DS=new List<Batdongsan>();
//         public void Nhap()
//         {
//             Console.OutputEncoding=System.Text.Encoding.UTF8;
//             string filepath="BDS.txt";
//             if(File.Exists(filepath))
//             {
//                 string[]lines=File.ReadAllLines(filepath);
//                 foreach(string line in lines)
//                 {
//                     string[]data=line.Split(";");
//                     Batdongsan bds=new Batdongsan
//                     {
//                         MaBDS=data[0].Trim(),
//                         TenBDS=data[1].Trim(),
//                         Huong=data[2].Trim(),
//                         Diachi=data[3].Trim(),
//                         Dientich=double.Parse(data[4]),
//                         Giaban=double.Parse(data[5]),
//                     };
//                     DS.Add(bds);
                   
//                 }
//                  Console.WriteLine("Da them");
//             }
//             else{
//                 Console.WriteLine("Khong co du lieu");
//             }
//         }
//         public void xuat()
//         {
//             foreach (Batdongsan bds in DS)
//             {
//                 Console.WriteLine("Mabds:"+bds.MaBDS);
//                 Console.WriteLine("Tenbds:"+bds.TenBDS);
//                 Console.WriteLine("Huong:"+bds.Huong);
//                 Console.WriteLine("Diachi:"+bds.Diachi);
//                 Console.WriteLine("Dientich:"+bds.Dientich);
//                 Console.WriteLine("Giaban:"+bds.Giaban);
//                 Console.WriteLine("-------------------------------------");
//             }
//         }
//         public void them()
//         {
//             Batdongsan bds=new Batdongsan();
//             Console.Write("Nhap Mabds:");
//             bds.MaBDS=Console.ReadLine();
//             Console.Write("Nhap Tenbds:");
//             bds.TenBDS=Console.ReadLine();
//             Console.Write("Huong:");
//             bds.Huong=Console.ReadLine();
//             Console.Write("Nhap Diachi:");
//             bds.Diachi=Console.ReadLine();
//             Console.Write("Nhap Dientich:");
//             bds.Dientich=double.Parse(Console.ReadLine());
//             Console.Write("Nhap Giaban:");
//             bds.Giaban=double.Parse(Console.ReadLine());
//             DS.Add(bds);
//         }
//         public void sua()
//         {
//             Console.Write("Nhap Ma BDS muon sua thong tin:");
//             string mabds=Console.ReadLine();
//             Batdongsan bds=DS.FirstOrDefault(bds=>bds.MaBDS==mabds);
//             Console.Write("Nhap Tenbds:");
//             bds.TenBDS=Console.ReadLine();
//             Console.Write("Huong:");
//             bds.Huong=Console.ReadLine();
//             Console.Write("Nhap Diachi:");
//             bds.Diachi=Console.ReadLine();
//             Console.Write("Nhap Dientich:");
//             bds.Dientich=double.Parse(Console.ReadLine());
//             Console.Write("Nhap Giaban:");
//             bds.Giaban=double.Parse(Console.ReadLine());
            
//         }
//         public void xoa()
//         {
//             Console.Write("Nhap MaBDS muon xoa:");
//             string mabds=Console.ReadLine();
//             Batdongsan bds =DS.FirstOrDefault(bds=>bds.MaBDS==mabds);
//             if(bds!=null)
//             {
//                 DS.Remove(bds);
//             }
//             else
//             {
//                 Console.Write("Khong tim thay ma bds trong ds");
//             }
            
//         }
//         public void TimThongTinBDSTheoTEN()
//         { 
//             Console.OutputEncoding=System.Text.Encoding.Unicode;
//             Console.InputEncoding=System.Text.Encoding.Unicode;
//             Console.Write("Nhap ten muon tim:");
//             string tenbds=Console.ReadLine().Trim();
//             var BDS=DS.Where(bds=>bds.TenBDS.ToLower()==tenbds.ToLower());
            
//              Console.WriteLine("THÔNG TIN BẤT ĐỘNG SẢN CÓ TÊN {0}",tenbds);
//             Console.WriteLine("         --------------------         ");
//             foreach(var bds in BDS)
//             {
//                 Console.WriteLine("Mabds:"+bds.MaBDS);
//                 Console.WriteLine("Tenbds:"+bds.TenBDS);
//                 Console.WriteLine("Huong:"+bds.Huong);
//                 Console.WriteLine("Diachi:"+bds.Diachi);
//                 Console.WriteLine("Dientich:"+bds.Dientich);
//                 Console.WriteLine("Giaban:"+bds.Giaban);
//                 Console.WriteLine("******************************");             
//             }
            
//         }
//         public void TimThongTinBDSTheoHuong()
//         {
//             Console.OutputEncoding=System.Text.Encoding.Unicode;
//             Console.InputEncoding=System.Text.Encoding.Unicode;
//             Console.Write("Nhap huong muon tim thong tin:");
//             string huong=Console.ReadLine().Trim();
//             var BDS=DS.Where(bds=>bds.Huong.ToLower()==huong.ToLower());
//             Console.WriteLine("THÔNG TIN BẤT ĐỘNG SẢN CÓ HƯỚNG {0}",huong);
//             Console.WriteLine("         --------------------         ");
//             foreach(var bds in BDS )
//             {
//                 Console.WriteLine("Mabds:"+bds.MaBDS);
//                 Console.WriteLine("Tenbds:"+bds.TenBDS);
//                 Console.WriteLine("Huong:"+bds.Huong);
//                 Console.WriteLine("Diachi:"+bds.Diachi);
//                 Console.WriteLine("Dientich:"+bds.Dientich);
//                 Console.WriteLine("Giaban:"+bds.Giaban);
//                 Console.WriteLine("******************************"); 
//             }
//         }
//         public void TimThongTinBDSTheoGia()
//         {
//             Console.OutputEncoding=System.Text.Encoding.Unicode;
//             Console.InputEncoding=System.Text.Encoding.Unicode;
//             Console.WriteLine("Khoảng giá bán muốn tìm a<=gia<=b");
//             Console.Write("Nhập a=");
//             double a=double.Parse(Console.ReadLine());
//             Console.Write("Nhập b=");
//             double b=double.Parse(Console.ReadLine());
//             var BDS=DS.Where(bds=> a<=bds.Giaban && bds.Giaban<=b)
//                                         .OrderBy (bds=> bds.Giaban);
            
//             Console.WriteLine("THÔNG TIN BẤT ĐỘNG SẢN NẰM TRONG KHOẢNG GIÁ TỪ {0} ĐẾN {1}:",a,b);
//             Console.WriteLine("             ----------------------------------                ");
//             foreach(var bds in BDS )
//             {
//                 Console.WriteLine("Mabds:"+bds.MaBDS);
//                 Console.WriteLine("Tenbds:"+bds.TenBDS);
//                 Console.WriteLine("Huong:"+bds.Huong);
//                 Console.WriteLine("Diachi:"+bds.Diachi);
//                 Console.WriteLine("Dientich:"+bds.Dientich);
//                 Console.WriteLine("Giaban:"+bds.Giaban);
//                 Console.WriteLine("******************************"); 
//             }
//         }
//     }
// }
using System;
using System.Collections;
using System.IO;
using System.Runtime.Versioning;
using System.Text;
using System.Collections.Generic;

namespace batdongsan
{
    class BDS
    {
        public string maBDS,tenBDS,huong,diachi,dientich,gia;
        public BDS(string maBDS,string tenBDS,string huong,string diachi,string dientich,string gia)
        {
            this.maBDS=maBDS;
            this.tenBDS=tenBDS;
            this.huong=huong;
            this.diachi=diachi;
            this.dientich=dientich;
            this.gia=gia;
        }
    }
    class danhsachBDS
    {
        public List<BDS> DS = new List<BDS>();
        public void nhapDS()
        {
            string input = File.ReadAllText(@"BDS.txt");
            string [,] res = new string[100,6];
            int i=0;
            foreach (var row in input.Split("\n"))
            {
                int j=0;
                foreach (var col in row.Trim().Split(";"))
                {
                    res[i,j]=col.Trim();
                    j++;
                }
                BDS bds = new BDS(res[i,0],res[i,1],res[i,2],res[i,3],res[i,4],res[i,5]);
                DS.Add(bds);
                i++;
            }
        }
        public void xuatDS()
        {
            foreach (var ds in DS)
            {
                Console.WriteLine($"{ds.maBDS} ; {ds.tenBDS} ; {ds.huong} ; {ds.diachi} ; {ds.dientich} ; {ds.gia}");
            }
        }

        public void them_moi()
        {
            Console.Write("Nhap ma BDS: ");
            string ma=Console.ReadLine();
            while (true)
            {
                int t=0;
                foreach (var ds in DS)
                {
                    if (ds.maBDS==ma)
                    {
                        t=1;
                        break;
                    }
                }
                if (t==0) { break;}
                Console.WriteLine("Ma da ton tai. Vui long nhap lai.");
            }
            Console.Write("Ten BDS: ");
            string ten=Console.ReadLine();
            Console.Write("Huong: ");
            string Huong=Console.ReadLine();
            Console.Write("Dia chi: ");
            string dc=Console.ReadLine();
            Console.Write("Dien tich: ");
            string dt=Console.ReadLine();
            Console.Write("Gia ban: ");
            string Gia=Console.ReadLine();
            BDS bds = new BDS(ma,ten,Huong,dc,dt,Gia);
            DS.Add(bds);
        }
        public void sua()
        {
            Console.Write("Nhap ma BDS can sua: ");
            string ma=Console.ReadLine();
            int t=0;
            foreach (var ds in DS)
            {
                if (ds.maBDS==ma)
                {
                    t=1;    
                    Console.Write("Ten: ");
                    ds.tenBDS = Console.ReadLine();
                    Console.Write("Huong: ");
                    ds.huong = Console.ReadLine();                        
                    Console.Write("Dia chi: ");
                    ds.diachi = Console.ReadLine();
                    Console.Write("Dien tich: ");
                    ds.dientich = Console.ReadLine();
                    Console.Write("Gia ban: ");
                    ds.gia = Console.ReadLine();
                    break;
                }
            }
            if (t==0) {Console.WriteLine("Khong co ma BDS muon sua");}
        }
        public void xoa()
        {
            Console.Write("Nhap ma BDS can xoa: ");
            string ma=Console.ReadLine();
            int t=0;
            for (int i=0;i<DS.Count;i++)
            {
                if (DS[i].maBDS==ma)
                {
                    t=1;    
                    DS.RemoveAt(i);
                    break;
                }
            }
            if (t==0) {Console.WriteLine("Khong co ma BDS muon xoa");}
        }
        public void timTheoTen()
        {
            Console.Write("Nhap ten BDS can tim: ");
            string ten=Console.ReadLine();
            int t=0;
            foreach (var ds in DS)
            {
                if (ds.tenBDS==ten)
                {
                    t=1;    
                    Console.WriteLine($"{ds.maBDS} ; {ds.tenBDS} ; {ds.huong} ; {ds.diachi} ; {ds.dientich} m2 ; {ds.gia} tỷ VNĐ");
                }
            }
            if (t==0) {Console.WriteLine("Khong tim thay");}
        }
        public void timTheoHuong()
        {
            Console.Write("Nhap huong BDS can tim: ");
            string Huong=Console.ReadLine();
            int t=0;
            foreach (var ds in DS)
            {
                if (ds.huong==Huong)
                {
                    t=1;    
                    Console.WriteLine($"{ds.maBDS} ; {ds.tenBDS} ; {ds.huong} ; {ds.diachi} ; {ds.dientich} m2 ; {ds.gia} tỷ VNĐ");
                }
            }
            if (t==0) {Console.WriteLine("Khong tim thay");}
        }
        public void timTheoGia()
        {
            Console.WriteLine("Nhap khoang gia can tim: ");
            Console.WriteLine("Bat dau tu gia: ");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Den gia: ");
            double b=Convert.ToDouble(Console.ReadLine());
            List<double> Gia = new List<double>(); 
            foreach (var ds in DS)
            {
                double g=Convert.ToDouble(ds.gia);
                if (g>=a & g<=b)
                {   
                    Gia.Add(g);
                }
            }
            string [] ma = new string[DS.Count];
            int j=0;
            Gia.Sort();
            foreach (double g in Gia)
            {
                foreach (var ds in DS)
                {   
                    double p=Convert.ToDouble(ds.gia);
                    if (p==g & Array.IndexOf(ma,ds.maBDS)==-1) 
                    {
                        Console.WriteLine($"{ds.maBDS} ; {ds.tenBDS} ; {ds.huong} ; {ds.diachi} ; {ds.dientich} m2 ; {ds.gia} tỷ VNĐ");
                        ma[j]=ds.maBDS;
                        j++;
                        break;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            danhsachBDS ds = new danhsachBDS();
            ds.nhapDS();
            while (true)
            {
                Console.WriteLine("Chuong trinh quan ly BDS:");
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("# 1. Them moi danh sach.");
                Console.WriteLine("# 2. Sua thong tin.");
                Console.WriteLine("# 3. Xoa thong tin.");
                Console.WriteLine("# 4. Xuat danh sach.");
                Console.WriteLine("# 5. Tim theo Ten.");
                Console.WriteLine("# 6. Tim theo Huong.");
                Console.WriteLine("# 7. Tim theo Gia.");
                Console.WriteLine("# 0. Exit.");
                Console.WriteLine("-----END!!!-----");
                Console.Write("Vui long chon yeu cau: ");
                int need = int.Parse(Console.ReadLine());
                if (need == 0)
                {
                    Console.WriteLine("-----Ket thuc chuong trinh-----");
                    break;
                }
                else if (need == 1)
                {
                    Console.WriteLine("-----Them mới danh sach-----");
                    ds.them_moi();
                    Console.WriteLine("----------------------------\n");
                }
                else if (need == 2)
                {
                    Console.WriteLine("-----Sua thong tin-----");
                    ds.sua();
                    Console.WriteLine("----------------------------\n");
                }
                else if (need == 3)
                {
                    Console.WriteLine("-----Xoa thong tin-----");
                    ds.xoa();
                    Console.WriteLine("----------------------------\n");
                }
                else if (need == 4)
                {
                    Console.WriteLine("-----Xuat danh sach-----");
                    ds.xuatDS();
                    Console.WriteLine("----------------------------\n");
                }
                else if (need == 5)
                {
                    Console.WriteLine("-----Tim theo Ten-----");
                    ds.timTheoTen();
                    Console.WriteLine("----------------------------\n");
                }
                else if (need == 6)
                {
                    Console.WriteLine("-----Tim theo Huong-----");
                    ds.timTheoHuong();
                    Console.WriteLine("----------------------------\n");
                }
                else if (need == 7)
                {
                    Console.WriteLine("-----Tim theo Gia-----");
                    ds.timTheoGia();
                    Console.WriteLine("----------------------------\n");
                }
                else
                {
                    Console.WriteLine("-----Yeu cau khong đung moi nhap lai-----\n");
                }
            }
        }
    }
}


