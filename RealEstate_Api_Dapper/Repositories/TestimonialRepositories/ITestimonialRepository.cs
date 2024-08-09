
using RealEstate_Api_Dapper.Dtio.TestimonialDtio;

namespace RealEstate_Api_Dapper.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDtio>> GetAllTestimonailAsync();
       
    }
}
