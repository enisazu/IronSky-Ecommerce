using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BannerService : IBannerService
    {
        private readonly IBannerDal _bannerDal;

        public BannerService(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

      

        public Banner GetBanner(int id)
        {
            return _bannerDal.Get(x => x.Id == id);

            //var result = _bannerDal.Get(x => x.Id == id);

            //if (id == 1 || id == 4)
            //{
            //    return result;

            //}
            //else
            //{
            //    return null;
            //}

        }

        public List<Banner> GetBanners()
        {
            return _bannerDal.List();
        }
    }
}
