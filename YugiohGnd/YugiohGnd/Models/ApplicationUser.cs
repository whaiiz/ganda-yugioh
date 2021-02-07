using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using YugiohGnd.ValidationAttributes;

namespace YugiohGnd.Models
{
    public class ApplicationUser : IdentityUser
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

        [NotNull]
        public int CountryId { get; set; }

        [Required]
        public Country Country { get; set; }

    }
}
