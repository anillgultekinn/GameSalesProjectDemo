using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ValidationManager : IValidationUserService
    {
        public bool Validate(User user)
        {

            if (user.TcNo == "12345678910" && user.FirstName == "Anıl" && user.BirthYear == 1997)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
