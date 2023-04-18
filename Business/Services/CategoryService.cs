using  DataAccess.Abstract;
using  Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CategoryService : ICategoryService
    {   
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetCategory(string seoName)
        {
            // localhost/kategori/beyaz-esya
            return _categoryDal.Get(x => x.SeoName == seoName);
        }

        public List<Category> List()
        {
            var result = _categoryDal.List();
            return result;
        }
    }
}
