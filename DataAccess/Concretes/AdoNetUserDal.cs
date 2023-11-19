using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetUserDal : IUserDal
    {
        public void Add(User user)
        {
            Console.WriteLine("AdoNet  kullanılarak {0}  eklendi.", user.FirstName, user.LastName);
        }

        public void Delete(User user)
        {
            Console.WriteLine("AdoNet  kullanılarak {0}  silindi.", user.FirstName, user.LastName);

        }

        public void Update(User user)
        {
            Console.WriteLine("AdoNet  kullanılarak {0}  güncellendi.", user.FirstName, user.LastName);

        }
    }
}
