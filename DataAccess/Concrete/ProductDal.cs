using  Core.DataAccess;
using  DataAccess.Abstract;
using  Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DataAccess.Concrete
{
    public class ProductDal : RepositoryBase<Product,  Context>, IProductDal
    {
        public List<ProductImagesCustomModel> GetProductsWithImages()
        {
            using ( Context c = new  Context())
            {
                var result = (from p in c.Products /* p aslında Products tablosunu temsil eden kısa isim*/
                              join pi in c.ProductImages /* pi ProductImages tablosu kısa adi*/
                              on p.Id equals pi.ProductId // Product tablosu ile ProductImages tablosunu birleştirmek içim p.Id ile pi.ProductId ile joinliyoruz.
                              select new ProductImagesCustomModel // select aslıdna 2 tabloyu birleştirip bize istedimiz bir türde almamızı sağlıyor.
                              {
                                  Description = p.Description,
                                  Id = p.Id,
                                  Image = pi.Name,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName,
                                  Status = p.Status,
                                  
                                  

                              }).ToList();
                return result;

            }
        }

        public List<CategoryProductsCustomModel> GetCategoryProduct(int categoryId, int? page)
        {
            int pageProductCount = 12;// sayfa başı görünecek ürün adeti
            int takeProduct = 0;
            if (page == null || page == 1)
            {
                takeProduct = 0;
            }
            else
            {
                takeProduct = (pageProductCount * (page.Value - 1));
            }
            using ( Context c = new  Context())
            {
                var result = (from p in c.Products
                              join cp in c.CategoryProducts
                              on p.Id equals cp.ProductId
                              select new CategoryProductsCustomModel
                              {
                                  Status = p.Status,
                                  Sort = cp.Sort,
                                  Counter = p.Counter,
                                  Description = p.Description,
                                  Id = p.Id,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName
                              }
                              ).OrderBy(x => x.Sort).ToList();
                result = result.Skip(takeProduct).Take(pageProductCount).ToList();
                return result;
            }
            
        }

        public int CategoryProductCount(int categoryId)
        {
            using (var c = new  Context())
            {
                return c.CategoryProducts.Count(x => x.CategoryId == categoryId);
            }
        }

        public List<CategoryProductsCustomModel> GetProductByPage(int? page)
        {
            int pageProductCount = 12;// sayfa başı görünecek ürün adeti
            int takeProduct = 0;
            if (page == null || page == 1)
            {
                takeProduct = 0;
            }
            else
            {
                takeProduct = (pageProductCount * (page.Value - 1));
            }
            using (Context c = new Context())
            {
                var result = (from p in c.Products
                              join cp in c.CategoryProducts
                              on p.Id equals cp.ProductId
                              select new CategoryProductsCustomModel
                              {
                                  Status = p.Status,
                                  Sort = cp.Sort,
                                  Counter = p.Counter,
                                  Description = p.Description,
                                  Id = p.Id,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName
                              }
                              ).OrderBy(x => x.Sort).ToList();
                result = result.Skip(takeProduct).Take(pageProductCount).ToList();
                return result;
            }
        }
    }
}
