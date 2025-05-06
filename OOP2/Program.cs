﻿using OOP2;

internal class Program
{
    private static void Main(string[] args)   //Soyutlama kavramı.
    {
        //Batuhan Aslan
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Batuhan";
        musteri1.Soyadi = "Aslan";
        musteri1.TcNo = "12345678910";


        //Kodlama.io

        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "54321";
        musteri2.SirketAdi = "Kodlama.io";
        musteri2.VergiNo = "1234567890";

        //Gerçek - Tüzel <<< ikisi de müşteri >>>>
        //SOLID --> L harfi

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2); 


    }
}