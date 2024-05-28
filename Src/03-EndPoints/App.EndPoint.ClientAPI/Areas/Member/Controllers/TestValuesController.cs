using App.Domain.Core.Activity.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.EndPoint.ClientAPI.Areas.Member.Controllers
{
    [Area("member")]
    //[Route("api/[Area]/[controller]/[Action]")]
    [Route("api/[Area]/[controller]")]
    [ApiController]
    public class TestValuesController : ControllerBase
    {
        // GET: api/<TestValuesController>
        
        [HttpGet]
        public IEnumerable<ResponsibilityDto> Get()
        {
            ResponsibilityDto test = new() { Id = 1 , EnName ="wewer" };
            return new ResponsibilityDto[] { test , test ,new() { Id = 5 , EnName ="wewer" }

            };
        }

        // GET api/<TestValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Route("[Action]")]
        // POST api/<TestValuesController>
        [HttpPost]
        public void Post([FromBody] ResponsibilityDto value)
        {

        }

        [Route("[Action]")]
        [HttpPost]
        public void PostTest([FromBody] string value)
        {

        }


        [HttpGet]
        [Route("[Action]")]
        public IEnumerable<DateOnly> GetNowDate()
        {
            //return DateOnly.FromDateTime(DateTime.Now);
            return new DateOnly[] { DateOnly.FromDateTime(DateTime.Now) };

        }

        [Route("[Action]")]
        [HttpPost]
        public IEnumerable<int> PostTestdId([FromBody] int id)
        {
            return new[] { id+3 };
        }


        [Route("[Action]/{id}")]
        [HttpPost]
        public IEnumerable<int> PostTestdId2(int id , [FromBody] int id2)
        {
            return new[] { id + 3 +id2 };
        }

        [HttpPost]
        public IEnumerable<string> Index([FromBody] string value)
        {
            return new[] { "sdfasdf" };
        }

        // PUT api/<TestValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
