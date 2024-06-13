using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICallFirstAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet("/avarage")]

        public async Task<string> avarage()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44301/avarage?nums=10&nums=2000&nums=1500&nums=950&nums=48078");
            return result;
        }
        [HttpGet("/smallest")]
        public async Task<string> smallest()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44301/smallest?nums=10&nums=2000&nums=1500&nums=950&nums=48078");
            return result;
        }

        [HttpGet("/largest")]
        public async Task<string> largest()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44301/largest?nums=10&nums=2000&nums=1500&nums=950&nums=48078");
            return result;
        }

    }
}
