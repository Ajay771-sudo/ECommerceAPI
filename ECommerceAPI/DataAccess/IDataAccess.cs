using ECommerceAPI.Models;

namespace ECommerceAPI.DataAccess
{
    public interface IDataAccess
    {
        List<ProductCategory> GetProductCategories();
    }
}
