using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IUserTokenService
    {
        UserToken Get(string token);
        void Add(string token, int userId);
    }
}
