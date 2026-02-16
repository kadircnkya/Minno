using ApiProjeCampWebUI.Dtos.ChefDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiProjeCampWebUI.ViewComponents
{
    public class _ChefDefaultComponentDefaultPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ChefDefaultComponentDefaultPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7260/api/Chefs/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultChefDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
