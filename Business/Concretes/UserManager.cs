using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {

        //bir manager sınıfı içerisinde başka bir manager sınıfır kullanmak istiyorsak onu newleme constructor ile yap
        IUserDal _userDal;
        IValidationUserService _validationUserService;

        //hangi veritabanını kullanacağımızı dışarıdan belirtmek için constructor kullandık (program cs de belirtiyoruz)
        //hangi validation türünü kullanacağımızı dışarıdan belirtmek için constructor kullandık
        public UserManager(IUserDal userdal, IValidationUserService validationUserService)

        {
            _userDal = userdal;
            _validationUserService = validationUserService;
        }

        public void Add(User user)
        {
            var result = _validationUserService.Validate(user);
            if (result)
            {
                _userDal.Add(user);
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı.");
            }
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public void Update(User user)
        {
            if (_validationUserService.Validate(user))
            {
                _userDal.Update(user);
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı.");
            }
        }
    }
}
