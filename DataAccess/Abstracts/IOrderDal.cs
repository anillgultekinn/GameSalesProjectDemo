using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IOrderDal
    {
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
