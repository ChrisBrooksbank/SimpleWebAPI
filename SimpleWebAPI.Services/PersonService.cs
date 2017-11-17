using SimpleWebAPI.Domain;

namespace SimpleWebAPI.Services
{
    public class PersonService : IPersonService
    {
        public Person GetCurrentPerson()
        {
            return new Person { FirstName = "Chris", LastName = "Brooksbank", DateOfBirth = new System.DateTime(1966, 8, 11) };
        }
    }
}
