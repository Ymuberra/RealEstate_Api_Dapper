using Dapper;
using RealEstate_Api_Dapper.Dtio.WhoWeAreDetailDtio;

using RealEstate_Api_Dapper.Models.DapperContext;

namespace RealEstate_Api_Dapper.Repositories.WhoWeAreRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;

        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }
        public async void CreateWhoWeAreDteail(CreateWhoWeAreDetailDtio createWhoWeAreDetailDtio)
        {


            String query = "insert into WhoWeAreDetail(Title,Subtitle,Description1,Description2) values(@title,@subtitle,@descrition1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDtio.Title);
            parameters.Add("@subtitle", createWhoWeAreDetailDtio.Subtitle);
            parameters.Add("@description1", createWhoWeAreDetailDtio.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDtio.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
            

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete From  WhoWeAreDetail Where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDtio>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * From WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDtio>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDetailDtio> GetWhoWeAreDetail(int id)
        {
            string query = "Select * From WhoWeAreDetail Where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDtio>(query, parameters);
                return values;
            }
        }

        public async void UpDateWhoWeAreDetail(UpdateWhoWeAreDetailDtio updateWhoWeAreDetailDtio)
        {
            string query = "Update WhoWeAreDetail Set Title=@title,Subtitle=@subtitle,Description1=@description1 ,Description2=@descripton2 where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDetailDtio.Title);
            parameters.Add("@subtitle", updateWhoWeAreDetailDtio.Subtitle);
            parameters.Add("@description1", updateWhoWeAreDetailDtio.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDtio.Description2);
            parameters.Add("@whoWeAreDetailID", updateWhoWeAreDetailDtio.WhoWeAreDetailId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
