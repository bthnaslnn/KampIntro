﻿using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamaya başlangıç için temel kurs";
        string kurs3 = "Java";
        string kurs4 = "Python";
        string kurs5 = "C++";


        Console.WriteLine(kurs1);
        Console.WriteLine(kurs2);
        Console.WriteLine(kurs3);
        Console.WriteLine(kurs4);
        Console.WriteLine(kurs5);
        //array - dizi

        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java","Python","C++" };

        for (int i = 0; i < kurslar.Length; i++)   //kurslar.Length diyerek dinamikleştiriyoruz.
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("For bitti");

        foreach (string kurs in kurslar)           //foreach ->< dizileri tek tek dolaşmaya yarar, döngü yöntemi olarak kullanılır.
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("Sayfa Sonu - footer ");
    }
}