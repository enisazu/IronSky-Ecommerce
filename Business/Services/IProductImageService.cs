using  Entities;
using System.Collections.Generic;

namespace  Business.Services
{
    public interface IProductImageService
    {
        List<ProductImage> GetImages(int productId);

        List<ProductImage> List(int productId = 0);
    }
}
