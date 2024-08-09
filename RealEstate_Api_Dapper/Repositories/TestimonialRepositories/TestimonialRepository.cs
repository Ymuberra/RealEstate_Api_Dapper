using Dapper;
using RealEstate_Api_Dapper.Dtio.TestimonialDtio;
using RealEstate_Api_Dapper.Models.DapperContext;

namespace RealEstate_Api_Dapper.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultTestimonialDtio>> GetAllTestimonailAsync()
        {
            string query = "Select * From Testimonil";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDtio>(query);
                return values.ToList();
            }
        }
    }
}
