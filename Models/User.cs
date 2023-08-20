using Microsoft.AspNetCore.Identity;

namespace WebApplication11.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public byte[]? Image { get; set; }
        //age
        //Gender
        //LastName


    }
}