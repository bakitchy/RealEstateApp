using RealEstate.API.Dtos.PopularLocationDtos;

namespace RealEstate.API.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationsAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocation);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocation);
        void DeletePopularLocation(int id);
        Task<GetByIDPopularLocationDto> GetByIDPopularLocationAsync(int id);
    }
}
