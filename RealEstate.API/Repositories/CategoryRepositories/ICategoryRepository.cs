using RealEstate.API.Dtos.CategoryDtos;

namespace RealEstate.API.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

    }
}
