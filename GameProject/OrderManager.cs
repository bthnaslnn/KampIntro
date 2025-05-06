using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOrderService
    {
        public void Add(Order order)
        {
            Console.WriteLine("Satış eklendi");
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Satış silindi");
        }

        public void Update(Order order)
        {
            Console.WriteLine("Satış güncellendi");
        }
    }
}
