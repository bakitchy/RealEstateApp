using RealEstate.API.Dtos.EmployeeDtos;

namespace RealEstate.API.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        Task<GetByIDEmployeeDto> GetByIDEmployee(int id);

        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void UpdateEmployee(UpdateEmployeeDto UpdateEmployeeDto);
        void DeleteEmployee(int id);

    }
}
