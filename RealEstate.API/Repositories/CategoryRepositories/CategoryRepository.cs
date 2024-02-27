using Dapper;
using Microsoft.AspNetCore.Mvc;
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

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (Name, Status) values (@name, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", categoryDto.Name);
            parameters.Add("@status", true );
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "delete from Category where Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
            
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

        public async void UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            string query = "update Category set Name = @name , Status = @status where Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", updateCategoryDto.Id);
            parameters.Add("@name", updateCategoryDto.Name);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query , parameters);
            }
        }
    }
}
