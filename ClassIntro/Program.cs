internal class Program
{
    private static void Main(string[] args)
    {
        string adi = "Batuhan";
        int yas = 25;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Batuhan Aslan";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Fethi Aslan";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Gülbahar Aslan";
        kurs3.IzlenmeOrani = 80;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Hüma - Ayça Nil Aslan";
        kurs4.IzlenmeOrani = 100;



        //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4}; // Kurs tipinde kurslar dizisini oluşturduğumuzda dinamik yapı elde etmiş oluyoruz.

        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
        }

        Console.WriteLine("Hello, World!");
    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}