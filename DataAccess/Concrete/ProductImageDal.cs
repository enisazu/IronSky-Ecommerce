using  Core.DataAccess;
using  DataAccess.Abstract;
using  Entities;

namespace  DataAccess.Concrete
{
    public class ProductImageDal : RepositoryBase<ProductImage,  Context>, IProductImageDal
    {
    }
}
