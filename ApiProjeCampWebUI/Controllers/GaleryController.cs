using ApiProjeCampWebUI.Dtos.CategoryDto;
using ApiProjeCampWebUI.Dtos.ImageDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace ApiProjeCampWebUI.Controllers
{
    public class GaleryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GaleryController(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> ImageList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7260/api/Images");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultImageDto>>(jsonData);
                return View(values);
            }
            return View();
        }
     
      

    }
}
