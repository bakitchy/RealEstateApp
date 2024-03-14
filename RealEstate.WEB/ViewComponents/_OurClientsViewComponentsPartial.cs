using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate.WEB.Dtos.TestimonialDtos;

namespace RealEstate.WEB.ViewComponents
{
    public class _OurClientsViewComponentsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OurClientsViewComponentsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44359/api/Testimonials");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
