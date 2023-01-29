using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TryJWT.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required, MaxLength(50)]
        public string firstName { get; set; }
        [Required, MaxLength(50)]
        public string lastName { get; set; }
    }
}
