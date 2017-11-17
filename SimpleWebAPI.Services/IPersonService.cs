using SimpleWebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebAPI.Services
{
    public interface IPersonService
    {
        Person GetCurrentPerson();
    }
}
