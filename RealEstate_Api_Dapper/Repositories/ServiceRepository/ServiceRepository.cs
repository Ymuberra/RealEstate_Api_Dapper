using Dapper;
using RealEstate_Api_Dapper.Dtio.CategoryDtio;
using RealEstate_Api_Dapper.Dtio.ServiceDtio;
using RealEstate_Api_Dapper.Models.DapperContext;

namespace RealEstate_Api_Dapper.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }
        public void CreateService(CreateServiceDtio createServiceDtio)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDtio>> GetAllServiceAsync()
        {
            string query = "Select * From Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDtio>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDServiceDtio> GetService(int id)
        {
            throw new NotImplementedException();
        }

        public void UpDateService(UpDateServiceDtio updateServiceDtio)
        {
            throw new NotImplementedException();
        }
    }
}
