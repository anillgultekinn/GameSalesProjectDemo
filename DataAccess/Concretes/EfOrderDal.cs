using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfOrderDal : IOrderDal
    {
        public void Add(Order order)
        {
            Console.WriteLine("Entity framework kullanılarak  yüklendi.");
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Entity framework kullanılarak  silindi.");

        }

        public void Update(Order order)
        {
            Console.WriteLine("Entity framework kullanılarak  güncellendi.");

        }
    }
}
