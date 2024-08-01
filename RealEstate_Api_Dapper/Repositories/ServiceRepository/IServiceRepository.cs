using RealEstate_Api_Dapper.Dtio.ServiceDtio;

namespace RealEstate_Api_Dapper.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDtio>> GetAllServiceAsync();
        void CreateService(CreateServiceDtio createServiceDtio);
        void DeleteService(int id);
        void UpDateService(UpDateServiceDtio updateServiceDtio);
        Task<GetByIDServiceDtio> GetService(int id);
    }
}
