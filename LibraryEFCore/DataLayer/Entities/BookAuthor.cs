using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public  class BookAuthor
    {
        private BookAuthor()
        {
        }

        internal BookAuthor(Author author, Book book)
        {
            Author = author;
            Book = book;
        }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
