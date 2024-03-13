// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };
    public static int getKodePos(Kelurahan kelurahan)
    {
        if (kelurahan == Kelurahan.Batununggal)
        {
            return 40266;
        }
        if (kelurahan == Kelurahan.Kujangsari)
        {
            return 40287;
        }
        if (kelurahan == Kelurahan.Mengger)
        {
            return 40267;
        }
        if (kelurahan == Kelurahan.Wates)
        {
            return 40256;
        }
        if (kelurahan == Kelurahan.Cijaura)
        {
            return 40287;
        }
        if (kelurahan == Kelurahan.Jatisari)
        {
            return 40286;
        }
        if (kelurahan == Kelurahan.Margasari)
        {
            return 40286;
        }
        if (kelurahan == Kelurahan.Sekejati)
        {
            return 40286;
        }
        if (kelurahan == Kelurahan.Kebonwaru)
        {
            return 40272;
        }
        if (kelurahan == Kelurahan.Maleer)
        {
            return 40274;
        }
        if (kelurahan == Kelurahan.Samoja)
        {
            return 40273;
        }
        return 0;
    }
}

class main
{
    static void Main(String[] args)
    {

        KodePos kodePos = new KodePos();
        kodePos.getKodePos();
    }
}
