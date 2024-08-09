using RealEstate_Api_Dapper.Dtio.PopularLocationDtio;

namespace RealEstate_Api_Dapper.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDtio>> GetAllPopularLocationAsync();
        
    }
}
