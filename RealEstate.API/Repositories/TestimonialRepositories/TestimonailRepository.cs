using Dapper;
using RealEstate.API.Dtos.BottomGridDtos;
using RealEstate.API.Dtos.TestimonialDtos;
using RealEstate.API.Models;

namespace RealEstate.API.Repositories.TestimonialRepositories
{
    public class TestimonailRepository : ITestimonailRepository
    {
        private readonly Context _context;

        public TestimonailRepository(Context context)
        {
            _context = context;
        }

        public void CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTestimonial(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "select * from Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDTestimonialDto> GetByIDTestimonialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            throw new NotImplementedException();
        }
    }
}
