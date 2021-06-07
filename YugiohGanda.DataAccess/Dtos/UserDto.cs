using System;
using System.Collections.Generic;
using YugiohGanda.Core.Models;

namespace YugiohGanda.Core.Dtos
{
    public class UserDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int CurrentDeckId { get; set; }

        public Deck CurrentDeck { get; set; }

        public ICollection<Card> Cards { get; set; }

        public ICollection<Deck> Decks { get; set; }
    }
}
