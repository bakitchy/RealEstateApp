using Dapper;
using RealEstate.API.Dtos.PopularLocationDtos;
using RealEstate.API.Dtos.TestimonialDtos;
using RealEstate.API.Models;

namespace RealEstate.API.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public void CreatePopularLocation(CreatePopularLocationDto createPopularLocation)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationsAsync()
        {
            string query = "select * from PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDPopularLocationDto> GetByIDPopularLocationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocation)
        {
            throw new NotImplementedException();
        }
    }
}
