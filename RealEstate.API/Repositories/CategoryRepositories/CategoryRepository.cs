using Dapper;
using RealEstate.API.Dtos.CategoryDtos;
using RealEstate.API.Models;

namespace RealEstate.API.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
                _context = context;
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
