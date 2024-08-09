using RealEstate_Api_Dapper.Dtio.BottomGridDtio;
using RealEstate_Api_Dapper.Dtio.ServiceDtio;

namespace RealEstate_Api_Dapper.Repositories.BottomGridRepositories

{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDtio>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDtio createBottomGridDtio);
        void DeleteBottomGrid(int id);
        void UpDateBottomGrid(UpdateBottomGridDtio updateBottomGridDtio);
        Task<GetBottomGridDtio> GetBottomGrid(int id);
    }
}
