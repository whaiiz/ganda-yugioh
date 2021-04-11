using System;

namespace YugiohGanda.Core.Models
{
    public class BaseEntity
    {
        public User CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public User UpdateBy { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
