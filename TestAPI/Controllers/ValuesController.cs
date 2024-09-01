using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        


        [HttpGet]
        public ActionResult<Person> Test()
        {
            Person person = new Person() { Name = "amir", Password = "1234" };

            return person;

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
