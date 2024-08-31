using System;
class SUCKHOE
{
    private string CCCD;
    private string TenBN;
    private string GioiTinh;
    private string Benh;
    private string Khuvuc;
    private string Mucdo;

    public string cccd { get { return CCCD; } set { CCCD = value; } }
    public string tenBN { get { return TenBN; } set { TenBN = value; } }
    public string gioiTinh { get { return GioiTinh; } set { GioiTinh = value; } }
    public string benh { get { return Benh; } set { Benh = value; } }
    public string khuvuc { get { return Khuvuc; } set { Khuvuc = value; } }
    public string mucdo { get { return Mucdo; } set { Mucdo = value; } }
}
class Dichte
{
    private List<SUCKHOE> Danhsach = new List<SUCKHOE>();


    public void ThemBenhNhan(SUCKHOE bn)
    {
        Danhsach.Add(bn);
    }

    public void XoaBenhNhan(SUCKHOE bn)
    {
        Danhsach.Remove(bn);
    }

    public void CapNhat()
    {
        //  định nghĩa hàm so sánh được truyền làm tham số cho phương thức Sort. Hàm so sánh này được sử dụng để so sánh hai đối tượng SUCKHOE theo thuộc tính benh.
        //  Nếu benh của x nhỏ hơn benh của y, thì x sẽ đứng trước y trong danh sách được sắp xếp. Ngược lại, nếu benh của x lớn hơn hoặc bằng benh của y, thì y sẽ đứng trước x trong danh sách được sắp xếp.
        // Danhsach.Sort((x, y) => x.benh.CompareTo(y.benh));
        foreach (SUCKHOE bn in Danhsach)
        {
            Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
        }
    }

    public void NhapVien()
    {
        Console.WriteLine("Danh sach benh nhan can nhap vien:");
        foreach (SUCKHOE bn in Danhsach)
        {
            if (bn.benh != "Lao" && bn.benh != "Covid" && (bn.mucdo == "Trung binh" || bn.mucdo == "Nang"))
            {
                Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
            }
        }
    }

    public void XuatVien()
    {
        List<SUCKHOE> DanhsachXoa = new List<SUCKHOE>();
        foreach (SUCKHOE bn in Danhsach)
        {
            if (bn.mucdo == "Nhe")
            {
                DanhsachXoa.Add(bn);
            }
        }
        foreach (SUCKHOE bn in DanhsachXoa)
        {
            Danhsach.Remove(bn);
        }
        Console.WriteLine("Danh sach benh nhan con lai sau khi xoa:");
        foreach (SUCKHOE bn in Danhsach)
        {
            Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
        }
    }
}

class QuanlySuckhoe
{
    private Dichte DanhSach = new Dichte();

    public void File(string tenfile)
    {
        // string sr = new string(tenfile);
        StreamReader sr = new StreamReader(tenfile);
        string i;
        while ((i = sr.ReadLine()) != null)
        {
            string[] arr = i.Split(',');
            SUCKHOE bn = new SUCKHOE();
            bn.cccd = arr[0];
            bn.tenBN = arr[1];
            bn.gioiTinh = arr[2];
            bn.benh = arr[3];
            bn.khuvuc = arr[4];
            bn.mucdo = arr[5];
            DanhSach.ThemBenhNhan(bn);
        }
    }
    

 
    public void CapNhat()
    {
        DanhSach.CapNhat();
    }

    public void NhapVien()
    {
        DanhSach.NhapVien();
    }

    public void XuatVien()
    {
        DanhSach.XuatVien();
    }
}

class Program
{
    static void Main(string[] args)
    {
        QuanlySuckhoe qlsk = new QuanlySuckhoe();
        qlsk.File("sk.txt");
        int chon = -1;
        while (chon != 0)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Bam 1: Cap nhat");
            Console.WriteLine("Bam 2: Nhap vien");
            Console.WriteLine("Bam 3: Xuat vien");
            Console.WriteLine("Bam 0: Exit");
            Console.Write("Nhap lua chon: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    qlsk.CapNhat();
                    break;
                case 2:
                    qlsk.NhapVien();
                    break;
                case 3:
                    qlsk.XuatVien();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }
        }
    }
}

// // using System;
// // class SUCKHOE
// // {
// //     private string CCCD;
// //     private string TenBN;
// //     private string GioiTinh;
// //     private string Benh;
// //     private string Khuvuc;
// //     private string Mucdo;

// //     public string cccd { get { return CCCD; } set { CCCD = value; } }
// //     public string tenBN { get { return TenBN; } set { TenBN = value; } }
// //     public string gioiTinh { get { return GioiTinh; } set { GioiTinh = value; } }
// //     public string benh { get { return Benh; } set { Benh = value; } }
// //     public string khuvuc { get { return Khuvuc; } set { Khuvuc = value; } }
// //     public string mucdo { get { return Mucdo; } set { Mucdo = value; } }
// // }
// // class Dichte
// // {
// //     private List<SUCKHOE> Danhsach = new List<SUCKHOE>();


// //     public void ThemBenhNhan(SUCKHOE bn)
// //     {
// //         Danhsach.Add(bn);
// //     }

// //     public void XoaBenhNhan(SUCKHOE bn)
// //     {
// //         Danhsach.Remove(bn);
// //     }

// //     public void CapNhat()
// //     {
// //         Danhsach.Sort((x, y) => x.benh.CompareTo(y.benh));
// //         foreach (SUCKHOE bn in Danhsach)
// //         {
// //             Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
// //         }
// //     }

// //     public void NhapVien()
// //     {
// //         Console.WriteLine("Danh sach benh nhan can nhap vien:");
// //         foreach (SUCKHOE bn in Danhsach)
// //         {
// //             if (bn.benh != "Lao" && bn.benh != "Covid" && (bn.mucdo == "Trung binh" || bn.mucdo == "Nang"))
// //             {
// //                 Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
// //             }
// //         }
// //     }

// //     public void XuatVien()
// //     {
// //         List<SUCKHOE> DanhsachXoa = new List<SUCKHOE>();
// //         foreach (SUCKHOE bn in Danhsach)
// //         {
// //             if (bn.mucdo == "Nhe")
// //             {
// //                 DanhsachXoa.Add(bn);
// //             }
// //         }
// //         foreach (SUCKHOE bn in DanhsachXoa)
// //         {
// //             Danhsach.Remove(bn);
// //         }
// //         Console.WriteLine("Danh sach benh nhan con lai sau khi xoa:");
// //         foreach (SUCKHOE bn in Danhsach)
// //         {
// //             Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
// //         }
// //     }
// // }

// // class QuanlySuckhoe
// // {
// //     private Dichte DanhSach = new Dichte();

// //     // public void File(string tenfile)
// //     // {
// //     //     string sr = new string(tenfile);
// //     //     string i;
// //     //     while ((i = sr.ReadLine()) != null)
// //     //     {
// //     //         string[] arr = i.Split(',');
// //     //         SUCKHOE bn = new SUCKHOE();
// //     //         bn.cccd = arr[0];
// //     //         bn.tenBN = arr[1];
// //     //         bn.gioiTinh = arr[2];
// //     //         bn.benh = arr[3];
// //     //         bn.khuvuc = arr[4];
// //     //         bn.mucdo = arr[5];
// //     //         DanhSach.ThemBenhNhan(bn);
// //     //     }
// //     // }
// //     public void File(string tenfile)
// // {
// //     StreamReader sr = new StreamReader(tenfile);
// //     string i;
// //     while ((i = sr.ReadLine()) != null)
// //     {
// //         string[] arr = i.Split(',');
// //         SUCKHOE bn = new SUCKHOE();
// //         bn.cccd = arr[0];
// //         bn.tenBN = arr[1];
// //         bn.gioiTinh = arr[2];
// //         bn.benh = arr[3];
// //         bn.khuvuc = arr[4];
// //         bn.mucdo = arr[5];
// //         DanhSach.ThemBenhNhan(bn);
// //     }
// //     sr.Close();
// // }

// //     public void NhapTuFile()
// //     {
// //         string filePath = "danhsach.txt";
// //         if (File.Exists(filePath))
// //         {
// //             string[] lines = File.ReadAllLines(filePath);
// //             foreach (string line in lines)
// //             {
// //                 string[] items = line.Split(',');
// //                 SUCKHOE benhNhan = new SUCKHOE();
// //                 benhNhan.CCCD = items[0];
// //                 benhNhan.TenBN = items[1];
// //                 benhNhan.GioiTinh = items[2];
// //                 benhNhan.Benh = items[3];
// //                 benhNhan.Khuvuc = items[4];
// //                 benhNhan.Mucdo = items[5];
// //                 danhSachBenhNhan.Add(benhNhan);
// //             }
// //         }
// //         else
// //         {
// //             Console.WriteLine("Không tìm thấy file danh sách bệnh nhân.");
// //         }
// //     }
    

 
// //     public void CapNhat()
// //     {
// //         DanhSach.CapNhat();
// //     }

// //     public void NhapVien()
// //     {
// //         DanhSach.NhapVien();
// //     }

// //     public void XuatVien()
// //     {
// //         DanhSach.XuatVien();
// //     }
// // }

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         QuanlySuckhoe qlsk = new QuanlySuckhoe();
// //         qlsk.File(@"sk.txt");
// //         int chon = -1;
// //         while (chon != 0)
// //         {
// //             Console.WriteLine("Menu:");
// //             Console.WriteLine("Bam 1: Cap nhat");
// //             Console.WriteLine("Bam 2: Nhap vien");
// //             Console.WriteLine("Bam 3: Xuat vien");
// //             Console.WriteLine("Bam 0: Exit");
// //             Console.Write("Nhap lua chon: ");
// //             chon = int.Parse(Console.ReadLine());
// //             switch (chon)
// //             {
// //                 case 1:
// //                     qlsk.CapNhat();
// //                     break;
// //                 case 2:
// //                     qlsk.NhapVien();
// //                     break;
// //                 case 3:
// //                     qlsk.XuatVien();
// //                     break;
// //                 case 0:
// //                     break;
// //                 default:
// //                     Console.WriteLine("Lua chon khong hop le");
// //                     break;
// //             }
// //         }
// //     }
// // }

// using System;
// using System.Collections.Generic;
// using System.IO;

// class SUCKHOE
// {
//     private string CCCD;
//     private string TenBN;
//     private string GioiTinh;
//     private string Benh;
//     private string Khuvuc;
//     private string Mucdo;

//     public string cccd { get { return CCCD; } set { CCCD = value; } }
//     public string tenBN { get { return TenBN; } set { TenBN = value; } }
//     public string gioiTinh { get { return GioiTinh; } set { GioiTinh = value; } }
//     public string benh { get { return Benh; } set { Benh = value; } }
//     public string khuvuc { get { return Khuvuc; } set { Khuvuc = value; } }
//     public string mucdo { get { return Mucdo; } set { Mucdo = value; } }
// }

// class Dichte
// {
//     private List<SUCKHOE> Danhsach = new List<SUCKHOE>();

//     public void ThemBenhNhan(SUCKHOE bn)
//     {
//         Danhsach.Add(bn);
//     }

//     public void XoaBenhNhan(SUCKHOE bn)
//     {
//         Danhsach.Remove(bn);
//     }

//     public void CapNhat()
//     {
//         Danhsach.Sort((x, y) => x.benh.CompareTo(y.benh));
//         foreach (SUCKHOE bn in Danhsach)
//         {
//             Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
//         }
//     }

//     public void NhapVien()
//     {
//         Console.WriteLine("Danh sach benh nhan can nhap vien:");
//         foreach (SUCKHOE bn in Danhsach)
//         {
//             if (bn.benh != "Lao" && bn.benh != "Covid" && (bn.mucdo == "Trung binh" || bn.mucdo == "Nang"))
//             {
//                 Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
//             }
//         }
//     }

//     public void XuatVien()
//     {
//         List<SUCKHOE> DanhsachXoa = new List<SUCKHOE>();
//         foreach (SUCKHOE bn in Danhsach)
//         {
//             if (bn.mucdo == "Nhe")
//             {
//                 DanhsachXoa.Add(bn);
//             }
//         }
//         foreach (SUCKHOE bn in DanhsachXoa)
//         {
//             Danhsach.Remove(bn);
//         }
//         Console.WriteLine("Danh sach benh nhan con lai sau khi xoa:");
//         foreach (SUCKHOE bn in Danhsach)
//         {
//             Console.WriteLine("CCCD: " + bn.cccd + ", Ten benh nhan: " + bn.tenBN + ", Gioi tinh: " + bn.gioiTinh + ", Benh: " + bn.benh + ", Khu vuc: " + bn.khuvuc + ", Muc do: " + bn.mucdo);
//         }
//     }
// }

// class QuanlySuckhoe
// {
//     private Dichte DanhSach = new Dichte();

//    public void File(string tenfile) 
// {
//     StreamReader sr = new StreamReader(tenfile);
//     string i;
//     while ((i = sr.ReadLine()) != null)
//     {
//         string[] arr = i.Split(',');
//         if (arr.Length == 6) // check length of array
//         {
//             SUCKHOE bn = new SUCKHOE();
//             bn.cccd = arr[0];
//             bn.tenBN = arr[1];
//             bn.gioiTinh = arr[2];
//             bn.benh = arr[3];
//             bn.khuvuc = arr[4];
//             bn.mucdo = arr[5];
//             DanhSach.ThemBenhNhan(bn);
//         }
//     }
// }

//     public void CapNhat()
//     {
//         DanhSach.CapNhat();
//     }

//     public void NhapVien()
//     {
//         DanhSach.NhapVien();
//     }

//     public void XuatVien()
//     {
//         DanhSach.XuatVien();
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         QuanlySuckhoe qlsk = new QuanlySuckhoe();
//         qlsk.File("sk.txt");
//         int chon = -1;
//         while (chon != 0)
//         {
//             Console.WriteLine("Menu:");
//             Console.WriteLine("Bam 1: Cap nhat");
//             Console.WriteLine("Bam 2: Nhap vien");
//             Console.WriteLine("Bam 3: Xuat vien");
//             Console.WriteLine("Bam 0: Exit");
//             Console.Write("Nhap lua chon: ");
//             chon = int.Parse(Console.ReadLine());
//             switch (chon)
//             {
//                 case 1:
//                     qlsk.CapNhat();
//                     break;
//                 case 2:
//                     qlsk.NhapVien();
//                     break;
//                 case 3:
//                     qlsk.XuatVien();
//                     break;
//                 case 0:
//                     break;
//                 default:
//                     Console.WriteLine("Lua chon khong hop le");
//                     break;
//             }
//         }
//     }
// }
