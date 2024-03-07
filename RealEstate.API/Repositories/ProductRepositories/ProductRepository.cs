using Dapper;
using RealEstate.API.Dtos.ProductDtos;
using RealEstate.API.Models;

namespace RealEstate.API.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query =
                "Select Product.Id , Product.Title , Product.Price , Product.City , Product.District , Product.CoverImage, Product.Type, Product.Address, Category.Name from Product inner join Category on Product.ProductCategory = Category.Id";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
