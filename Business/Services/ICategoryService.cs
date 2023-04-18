using  Entities;
using System.Collections.Generic;

namespace Business.Services
{
    public interface ICategoryService
    {
        List<Category> List();
        Category GetCategory(string seoName);
    }
}
