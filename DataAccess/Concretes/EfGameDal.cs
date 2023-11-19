using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfGameDal : IGameDal
    {
        public void Add(Game game)
        {
            Console.WriteLine("Entity framework kullanılarak {0} yüklendi.", game.Name);

        }

        public void Delete(Game game)
        {
            Console.WriteLine("Entity framework kullanılarak {0} yüklendi.", game.Name);

        }

        public void Update(Game game)
        {
            Console.WriteLine("Entity framework kullanılarak {0}  yüklendi.", game.Name);

        }
    }
}
