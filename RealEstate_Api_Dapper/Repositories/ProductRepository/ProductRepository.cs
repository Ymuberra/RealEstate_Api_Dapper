using Dapper;
using RealEstate_Api_Dapper.Dtio.CategoryDtio;
using RealEstate_Api_Dapper.Dtio.ProductDtio;
using RealEstate_Api_Dapper.Models.DapperContext;

namespace RealEstate_Api_Dapper.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDtios>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDtios>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDtios>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,Coverimage,type,adress From Product inner join Category on " +
                "Product.ProductCategory=Category.CategoryID";
              
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDtios>(query);
                return values.ToList();
            }
        }

        
    }
}
