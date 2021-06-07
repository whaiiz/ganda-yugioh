using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using YugiohGanda.Core.ValidationAttributes;

namespace YugiohGanda.Core.Models
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

        public int? CurrentDeckId { get; set; }

        public Deck CurrentDeck { get; set; }

        public ICollection<Card> Cards { get; set; }

        public ICollection<Deck> Decks { get; set; }
    }
}
