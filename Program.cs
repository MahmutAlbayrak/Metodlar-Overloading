internal class Program
{
    private static void Main(string[] args)
    {
        //Alt parametreler
        string sayi = "999";

        bool sonuc = int.TryParse(sayi,out int outsayi);
        if (sonuc)
        {
            Console.WriteLine("Basarili");
            Console.WriteLine(outsayi);
        }
        else
            Console.WriteLine("Basarisiz");
        
        Metodlar instance = new Metodlar();
        instance.Topla(4,5,out int toplamSonuc);
        Console.WriteLine(toplamSonuc);

        //Metod Asiri Yukleme = Overloading

        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Mahmut"," Karizya");

        //Metod Imzası
        //MetodAdi + parametre sayisi + parametre
    }
}

class Metodlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }

}