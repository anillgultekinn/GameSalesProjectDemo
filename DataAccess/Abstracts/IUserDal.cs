using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IUserDal
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
