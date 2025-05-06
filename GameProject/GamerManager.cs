using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService

    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;   //Gamer Managere , Doğrulama servisini buraya bağımlı hale getirdik.

        public GamerManager(IUserValidationService userValidationService) //Constructor olarak bunu başarabildik ama eğer isteseydik metot parametresinde de çağırabilirdik.
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
