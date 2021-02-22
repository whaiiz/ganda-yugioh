using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using YugiohGanda.DataAccess.ValidationAttributes;

namespace YugiohGanda.DataAccess.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [PersonalData]
        [Required]
        [DateOfBirth(MinAge = 0, MaxAge = 150)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}
