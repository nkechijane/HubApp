using HubApp.Models;
using HubApp.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HubApp.Controllers
{
    public class HomeController : Controller
    {        
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] string State)
        {
            var result = new ResponseDTO();
            HttpClient webClient = new HttpClient();
            Uri uri = new Uri($"{_configuration["APISettings:findahub"]}getbystate?state={State}");
            var respon = await webClient.GetAsync(uri);
            var jsonString = await respon.Content.ReadAsStringAsync();
            result = JsonConvert.DeserializeObject<ResponseDTO>(jsonString);
            ViewData["result"] = result;
            return View();
        }
    }
}
