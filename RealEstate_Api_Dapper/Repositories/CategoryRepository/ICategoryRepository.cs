using RealEstate_Api_Dapper.Dtos.CategoryDtos;

namespace RealEstate_Api_Dapper.Repositories.CategoryRepository
{
    public interface ICategoryRepository

    {
        Task<List<ResultCategoryDtio>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDtio categoryDtio);
        void DeleteCategory(int id);
        void UpDateCategory(UpDateCategoryDtio categoryDtio);
        Task<GetByIDCategoryDtio> GetCategory(int id);
    }
}