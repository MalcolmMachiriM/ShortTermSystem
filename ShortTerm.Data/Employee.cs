using Microsoft.AspNetCore.Identity;

namespace ShortTerm.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
