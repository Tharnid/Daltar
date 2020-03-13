using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BandMatch.API.Models
{
    public class User
    {
       public int Id { get; set; } 
       public string Introduction { get; set; }
       public string LookingFor { get; set; }
       public string Username { get; set; }
       public string PreferredName { get; set; }  

       public string FirstName { get; set; }

       public string LastName { get; set; }
 
       public string Email { get; set; } 

       public byte[] PasswordHash { get; set; }
       public byte[] PasswordSalt { get; set; }
       public string Instrument { get; set; }  

       public string Vocals { get; set; }     
       public string Gender { get; set; } 
       public DateTime DateOfBith { get; set; }
       public DateTime Created { get; set; } 
       public DateTime LastActive { get; set; }
       public ICollection<Photo> Photos {get; set;}

    }
}