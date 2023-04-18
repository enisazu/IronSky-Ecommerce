using Business.Helpers;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IStringHelper _stringHelper;

        public UserService(IUserDal userDal, IStringHelper stringHelper)
        {
            _userDal = userDal;
            _stringHelper = stringHelper;
        }

        public User GetById(int userId)
        {
            return _userDal.Get(x => x.Id == userId);
        }

        public User Login(string username, string password)
        {
            password = _stringHelper.ToMd5(password);
            var result = _userDal.Query(x => x.Email == username && x.Password == password).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {

                return result;
            }
        }

        void IUserService.Add(User userData)
        {
            _userDal.Add(userData);
        }

        User IUserService.AdminLogin(string username, string password)
        {
            password = _stringHelper.ToMd5(password);
            var result = _userDal.Query(x => x.Email == username && x.Password == password && x.IsAdmin == true).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {

                return result;
            }
        }

        void IUserService.Delete(int id)
        {
            var user = _userDal.Get(x => x.Id == id);
            user.Status = false;
            _userDal.Update(user);
        }

        User IUserService.GetById(int userId)
        {
            return _userDal.Get(x => x.Id == userId);
        }

        List<User> IUserService.List()
        {
            return _userDal.List(x => x.Status == true);
        }

        User IUserService.Login(string username, string password)
        {
            // kullanıcının hangi tarihte başarılı login olduğunu bu kısımda if ve else arasında insert edelim 
            password = _stringHelper.ToMd5(password);
            var result = _userDal.Query(x => x.Email == username && x.Password == password).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {

                return result;
            }

        }

        void IUserService.Update(User userData)
        {
            _userDal.Update(userData); 
        }
    }
}
