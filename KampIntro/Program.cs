﻿internal class Program
{
    private static void Main(string[] args)
    {
        //type safety - tip güvenliği
        //Do not repeat yourself - Kendini tekrarlama
        //KategoriEtiketi --> Değer tutucudur. Alias.

        string KategoriEtiketi = "Kategoriler";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.55;
        double dolarBugun = 7.55;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (dolarDun<dolarBugun) 
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi butonu");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }

         Console.WriteLine(KategoriEtiketi);


    }
}