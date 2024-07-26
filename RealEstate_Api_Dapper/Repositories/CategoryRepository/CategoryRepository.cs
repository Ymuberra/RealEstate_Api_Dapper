using RealEstate_Api_Dapper.Dtos.CategoryDtos;
using RealEstate_Api_Dapper.Models.DapperContext;
using Dapper;

namespace RealEstate_Api_Dapper.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDtio categoryDtio)
        {
            String query = "insert into Category(CategoryName,CategoryStatus) values(@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDtio.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "Delete From Where CategoryID=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID",id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public  async Task<List<ResultCategoryDtio>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDtio>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDCategoryDtio> GetCategory(int id)
        {
            string query = "Select * From Category Where CategoryID=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@catagoryID", id);
            using (var connection = _context.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDtio>(query, parameters);
                return values;
            }

        }

        public async void UpDateCategory(UpDateCategoryDtio categoryDtio)
        {
            string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus where" +
                "CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDtio.CategoryName);
            parameters.Add("@categoryStatus", categoryDtio.CategoryStatus);
            parameters.Add("@categoryID", categoryDtio.CategoryID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

        
