using Dapper;
using RealEstate_Api_Dapper.Dtio.BottomGridDtio;
using RealEstate_Api_Dapper.Dtio.ProductDtio;
using RealEstate_Api_Dapper.Models.DapperContext;

namespace RealEstate_Api_Dapper.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {

        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        
        public void CreateBottomGrid(CreateBottomGridDtio createBottomGridDtio)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDtio>> GetAllBottomGridAsync()
        {
            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDtio>(query);
                return values.ToList();
            }
        }

        public Task<GetBottomGridDtio> GetBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDateBottomGrid(UpdateBottomGridDtio updateBottomGridDtio)
        {
            throw new NotImplementedException();
        }
    }
}
