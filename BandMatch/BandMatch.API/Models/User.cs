using System.ComponentModel.DataAnnotations;

namespace BandMatch.API.Models
{
    public class User
    {
       public int Id { get; set; } 
       [Required]
       [StringLength(20)]
       public string Username { get; set; }
       [Required]
       [StringLength(20)]
       public string FirstName { get; set; }
       [Required]
       [StringLength(20)]
       public string LastName { get; set; }
       [Required] 
       public string Email { get; set; } 
       [Required]
       public byte[] PasswordHash { get; set; }
       public byte[] PasswordSalt { get; set; }
       [Required]
       [StringLength(20)] 
       public string Instrument { get; set; }  
       [Required]
       [StringLength(20)] 
       public string Vocals { get; set; }     
    }
}