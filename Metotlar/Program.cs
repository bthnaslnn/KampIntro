﻿using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya Elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] {urun1,urun2};

        //type safe -- tip güvenli bir dil üzerinde kodlama yaptığımız için değişkenimizi tipini yazarak döngüde dönmesini sağlıyoruz. 
        foreach (Urun urun in urunler)
        { 
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("------------------");  
        }

        Console.WriteLine("-----------------------------METOTLAR--------------------");
        
        //encapsulation --> bir class'a sonradan bir prop ekleyip dinamik olarak devamlılık sağlayabilmek, ayrı ayrı yazmak yerine tek bir noktada yazabilmek..

        SepetManager sepetManager = new SepetManager(); // örnekleme -- instance >>oluşturuyoruz. 
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
        sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9 );
        sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);




    }
}


//Do not repeat yourself - Birden fazla kez kullanabiliyoruz metotları. - DRY - Clean Code. - Best Practice --> Doğru uygulama teknikleri.