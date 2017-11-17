using SimpleWebAPI.Services;
using StructureMap;

namespace SimpleWebAPI
{
    public class IOCRegistry: Registry
    {
        public IOCRegistry()
        {
            For<IPersonService>().Use<PersonService>();
        }

    }
}