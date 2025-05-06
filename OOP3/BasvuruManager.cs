using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {

        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //Hangi kredi türünü gönderirsek o kredi türünün class referansı çalışır.
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
