using RealEstate_Api_Dapper.Dtio.CategoryDtio;
using RealEstate_Api_Dapper.Dtio.ProductDtio;

namespace RealEstate_Api_Dapper.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDtios>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDtios>> GetAllProductWithCategoryAsync();
    }
}
