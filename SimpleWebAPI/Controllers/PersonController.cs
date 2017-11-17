using SimpleWebAPI.Domain;
using SimpleWebAPI.Services;
using System.Web.Http;

namespace SimpleWebAPI.Controllers
{
    public class PersonController : ApiController
    {
        private readonly IPersonService _personService;

        // http://structuremap.github.io/integrations/
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: api/Person
        public Person Get()
        {
            return _personService.GetCurrentPerson();
        }

    }
}
