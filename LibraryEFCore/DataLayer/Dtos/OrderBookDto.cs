using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dtos
{
    public class OrderBookDto
    {
        public int BookId { get; set; }
        public Book ChosenBook { get; set; }
        public short BookNumbers { get; set; }

        public OrderBookDto(int bookId, Book chosenBook, short bookNumbers)
        {
            BookId = bookId;
            BookNumbers = bookNumbers;
            ChosenBook = chosenBook ?? throw new ArgumentNullException(nameof(chosenBook));
        }
    }
}
