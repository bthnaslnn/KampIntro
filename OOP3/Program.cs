using OOP3;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args) //interfacelerde o classı implemente eden classın referansını tutabiliyor.
    { 
        IKrediManager ihtiyacKrediManager =   new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();

        List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKredisiManager(),loggers);
        
        List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



    }
}