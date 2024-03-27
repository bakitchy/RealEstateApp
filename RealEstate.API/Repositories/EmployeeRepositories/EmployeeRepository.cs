using Dapper;
using RealEstate.API.Dtos.EmployeeDtos;
using RealEstate.API.Models;

namespace RealEstate.API.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Employee(Name, Title, Mail, PhoneNumber, ImageUrl, Status) values (@name, @title, @mail, @phoneNumber, @imageUrl, @status)";

            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDto.Name);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Mail);
            parameters.Add("@phoneNumber", createEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", createEmployeeDto.ImageUrl);
            parameters.Add("@status", createEmployeeDto.Status);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "delete from Employee where Id=@Id";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "select * from Employee";

            var parameters = new DynamicParameters();
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }

        }

        public async Task<GetByIDEmployeeDto> GetByIDEmployee(int id)
        {
            string query = "select * from Employee where Id=@id";

            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "update Employee Set Name=@name, Title=@title, Mail=@mail, PhoneNumber=@phoneNumber, ImageUrl=@imageUrl, Status=@status where Id=@id";

            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phoneNumber", updateEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", updateEmployeeDto.Status);
            parameters.Add("@id", updateEmployeeDto.Id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
