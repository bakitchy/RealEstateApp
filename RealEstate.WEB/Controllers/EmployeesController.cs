using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate.WEB.Dtos.EmployeeDtos;

namespace RealEstate.WEB.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EmployeesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7026/api/Employees");

            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEmployeeDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
