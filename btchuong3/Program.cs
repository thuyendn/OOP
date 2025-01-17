public class Time
{
    private int Ngay; //--->int Ngay;
    int Thang;
    int Nam;
    int Gio;
    int Phut;
    int Giay;
    public void Hienthithoigian()
    {
        Console.WriteLine("Thoi gian htai la:Ngay{0},Thang{1},Năm {2},{3}Gio {4}Phut {5}Giay", Ngay,Thang,Nam,Gio,Phut,Giay);

    }
    public Time(System.DateTime Thoigian)
    {
        Ngay=Thoigian.Day;
        Thang=Thoigian.Month;
        Nam=Thoigian.Year;
        Gio=Thoigian.Hour;
        Phut=Thoigian.Minute;
        Giay=Thoigian.Second;
    }
}
class Apptinhthoigian
{
    static void Main()
    {
        System.DateTime Thoigianthuc=System.DateTime.Now;
        //Taoj đối tượng
        Time t=new Time(Thoigianthuc);
        t.Hienthithoigian();
    }
}