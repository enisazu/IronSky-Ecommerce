using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IBannerService
    {
        Banner GetBanner(int id);
        List<Banner> GetBanners();
    }
}
