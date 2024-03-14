using RealEstate.API.Dtos.TestimonialDtos;

namespace RealEstate.API.Repositories.TestimonialRepositories
{
    public interface ITestimonailRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        void DeleteTestimonial(int id);
        void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
        Task<GetByIDTestimonialDto> GetByIDTestimonialAsync(int id);
    }
}
