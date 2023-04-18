using  Core.DataAccess;
using  DataAccess.Abstract;
using  Entities;

namespace  DataAccess.Concrete
{
    public class CategoryDal : RepositoryBase<Category,  Context>, ICategoryDal
    {
    }
}
