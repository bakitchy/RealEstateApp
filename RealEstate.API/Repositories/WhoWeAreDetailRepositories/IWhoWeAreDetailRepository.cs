using RealEstate.API.Dtos.WhoWeAreDtos;

namespace RealEstate.API.Repositories.WhoWeAreRepositories
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDtoDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDtoDetail(int id);
        void UpdateWhoWeAreDtoDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);

    }
}
