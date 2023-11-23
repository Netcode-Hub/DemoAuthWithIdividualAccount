using Microsoft.AspNetCore.Identity;

namespace DemoAuthWithIdividualAccount.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? Fullname { get; set; }
    }

}
