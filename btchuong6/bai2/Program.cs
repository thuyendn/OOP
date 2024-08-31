using System;
interface Thietbi
{ 
    void On();
    void Off();
}
class Mayquat:Thietbi
{
    private int trangthai=0;
    public void On() {trangthai=1;Console.WriteLine("May quat da bat."); }
    public void Off() {trangthai=0;Console.WriteLine("May quat da tat.");}
}
class Dieuhoa:Thietbi
{
    private int trangthai=0;
    public void On() {trangthai=1;Console.WriteLine("Dieu hoa da bat.");}
    public void Off() {trangthai=0;Console.WriteLine("Dieu hoa da tat.");}
}
class Tivi:Thietbi
{
    private int trangthai=0;
    public void On() {trangthai=1; Console.WriteLine("Tivi da bat.");}
    public void Off() {trangthai=0;Console.WriteLine("Tivi da tat.");}
}
class Program
{
    static void Main()
    {
        Mayquat mq=new Mayquat();
        mq.On();

        Dieuhoa dh=new Dieuhoa();
        dh.Off();

        Tivi tv=new Tivi();
        tv.On();



    }
}
