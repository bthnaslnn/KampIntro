﻿using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);

        //isimler = new string[5]; // new'lediğimiz için isimler array'inin heap alanı yenilendi yani adres başka yeri gösterdiği için, eski elemanlar kayboldu.
        //isimler[4] = "İlker";
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[0]);

        List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("İlker");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);
        

    }
}