using Dapper;
using RealEstate.API.Dtos.WhoWeAreDtos;
using RealEstate.API.Models;

namespace RealEstate.API.Repositories.WhoWeAreRepositories
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;

        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAreDtoDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title, Subtitle, Description1, Description2) values (@title, @subtitle, @description1, @description2)";

            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", createWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDto.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDtoDetail(int id)
        {
            string query = "Delete from WhoWeAreDetail where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * from WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
        {
            string query = "Select * from WhoWeAreDetail where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDtoDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDto)
        {
            string query = "update WhoWeAreDetail Set Title=@title, Subtitle=@subTitle, Description1=@description1, Description2=@description2 where Id=@Id";

            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDto.Title);
            parameters.Add("@subTitle", updateWhoWeAreDto.SubTitle);
            parameters.Add("@description1", updateWhoWeAreDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDto.Description2);
            parameters.Add("@Id", updateWhoWeAreDto.Id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
