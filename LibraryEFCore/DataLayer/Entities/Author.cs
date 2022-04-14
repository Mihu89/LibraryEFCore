using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Author
    {
        public const int NameLength = 100;
        public const int EmailLength = 100;

        public int Id { get; set; }
        [Required(AllowEmptyStrings =false)]
        [MaxLength(NameLength)]
        public string Name { get; set; }
        [MaxLength(EmailLength)]
        public string Email { get; set; }
        public Author()
        {
        }
    }
}
