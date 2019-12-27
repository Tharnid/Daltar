using System.ComponentModel.DataAnnotations;

namespace BandMatch.API.Dtos
{
    public class UserForRegisterDto
    {
       [Required]
       [StringLength(20, MinimumLength = 4)]
       public string Username { get; set; }
       public string Password { get; set; }
       [Required]
       [StringLength(20)]
       public string FirstName { get; set; }
       [Required]
       [StringLength(20, MinimumLength = 4)]
       public string LastName { get; set; }
       [Required]
       public string Email { get; set; } 
       [Required]
       [StringLength(20, MinimumLength = 4)] 
       public string Instrument { get; set; }  
       [Required]
       [StringLength(20, MinimumLength = 4)] 
       public string Vocals { get; set; }     
    }
}