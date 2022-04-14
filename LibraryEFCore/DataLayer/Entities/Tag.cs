using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DataLayer.Entities
{
    public class Tag
    {
#pragma warning disable CS0649 // Field 'Tag._books' is never assigned to, and will always have its default value null
        private HashSet<Book> _books;
#pragma warning restore CS0649 // Field 'Tag._books' is never assigned to, and will always have its default value null
        [Key]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public IEnumerable<Book> Books => _books.ToList();
        public Tag(string name)
        {
            Name = name;
        }

    }
}