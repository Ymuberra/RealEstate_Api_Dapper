using RealEstate_Api_Dapper.Dtio.WhoWeAreDetailDtio;


namespace RealEstate_Api_Dapper.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {

        Task<List<ResultWhoWeAreDetailDtio>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDteail(CreateWhoWeAreDetailDtio createWhoWeAreDetailDtiocategoryDtio);
        void DeleteWhoWeAreDetail(int id);
        void UpDateWhoWeAreDetail(UpdateWhoWeAreDetailDtio updateWhoWeAreDetailDtio);
        Task<GetByIDWhoWeAreDetailDtio> GetWhoWeAreDetail(int id);
    }
}

