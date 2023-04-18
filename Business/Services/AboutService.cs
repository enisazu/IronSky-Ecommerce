using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class AboutService : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutService(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
         public void Add(About about)
        {
            _aboutDal.Add(about);
        }
  
        public List<About> List()
        {
            var result = _aboutDal.List();
            return result;

        }
 
        
    }
}
