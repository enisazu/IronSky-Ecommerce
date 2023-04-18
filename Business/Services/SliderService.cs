using  Business.Helpers;
using  DataAccess.Abstract;
using  Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Business.Services
{
    public class SliderService : ISliderService
    {
        ISliderDal _sliderDal;
        ICacheManager _cacheManager;

        public SliderService(ISliderDal sliderDal, ICacheManager cacheManager)
        {
            _sliderDal = sliderDal;
            _cacheManager = cacheManager;
        }

        public List<Slider> List()  
        {
            var cacheData = _cacheManager.Get<List<Slider>>("slider.list");
            if (cacheData == null)
            {
                var data = _sliderDal.List();
                _cacheManager.Set("slider.list", data);
                return data;
            }
            else
            {
                return cacheData;
            }
        }
    }
}
