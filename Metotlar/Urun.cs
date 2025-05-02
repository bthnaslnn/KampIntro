 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun   //ÜRÜNÜ ANLATAN BİR VERİ TİPİ
    {

        //Property -- Özellik manası.
        public int ID { get; set; }   // Bir datayı diğerlerinden ayırt edebilmemiz için eşsiz değer.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}