using SimpleWebAPI.Domain;
using SimpleWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebAPI.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public Person Get()
        {
            IPersonService personService = new PersonService();
            return personService.GetCurrentPerson();
        }

    }
}
