using  Core.DataAccess;
using  Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        List<ProductImagesCustomModel> GetProductsWithImages();
        List<CategoryProductsCustomModel> GetCategoryProduct(int categoryId, int? page);//ekleyin
        int CategoryProductCount(int categoryId);
        List<CategoryProductsCustomModel> GetProductByPage(int? page);

    }
}
