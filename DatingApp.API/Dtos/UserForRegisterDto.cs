using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 8 , ErrorMessage = "You must specify password between 8 and 16 charaters")]
        public string Password { get; set; }
    }
}