using  DataAccess.Abstract;
using  Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Business.Services
{
    public class ProductImageService : IProductImageService
    {
        IProductImageDal _productImageDal;

        public ProductImageService(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public List<ProductImage> GetImages(int productId)
        {
            return _productImageDal.List(x => x.ProductId == productId).OrderBy(s => s.Sort).ToList();
        }

        public List<ProductImage> List(int productId = 0)
        {
            return _productImageDal
                 .List(x => x.ProductId == productId)
                 .OrderBy(s => s.Sort)
                 .ToList();
        }
    }
}
