using System;

class Program
{

    static void Main()
    {
        LastikTuru araba = new LastikTuru();
        araba.Coupe = "BMW";
        
        YakitTuru benzin = new YakitTuru();
        benzin.Coupe = "Vw";
        ArabaTuru araba2 = araba;


        Galeri galeri = new Galeri();
        //galeri.Satis(benzin);
        galeri.Satis(araba2);
       // galeri.Satis(araba);  

    }
}
//base class:ArabaTuru
class ArabaTuru
{
    public string Sedan { get; set; }
    public string Coupe { get; set; }
    public string Suv { get; set; }
}
class LastikTuru:ArabaTuru
{
    public string Kis { get; set; }
    public string Yaz { get; set; }
}
class YakitTuru:ArabaTuru
{
    public string Dizel { get; set; }
    public string Benzin { get; set; }
}

class Galeri
{
    public void Satis(ArabaTuru arabaTuru)  //Base class içerdiği için her iki sınıf için çalıştı.
    {                                       //Aynı kodu farklı nesnelerde çalıştırabildik.                            
        Console.WriteLine(arabaTuru.Coupe + "  Satış gerçekleşti.");
    }
}