using  Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Business.Services
{
    public interface IProductService
    {
        List<ProductImagesCustomModel> ProductWithImages();
        Product Get(string seoName);
        void CountUp(Product product);
        Product Get(int id);
        List<CategoryProductsCustomModel> GetCategoryProducts(int categoryId,int? page);
        List<CategoryProductsCustomModel> GetCategoryProducts(int? page);
        int TotalPage(int categoryId);

        List<Product> GetAll();
        void Add(Product product);
    }
}
