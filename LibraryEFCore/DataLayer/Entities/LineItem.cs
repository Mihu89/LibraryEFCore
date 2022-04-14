using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class LineItem : IValidatableObject
    {
        public int Id { get; set; }
        [Range(1,5,ErrorMessage ="This order has limit of 5 books")]
        public byte LineLimit { get; set; }
        public short BookNumbers { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public Book ChosenBook { get; set; }

        private LineItem()
        {
        }
        internal LineItem(byte lineLimit, short bookNumbers, Book chosenBook)
        {
            LineLimit = lineLimit;
            BookNumbers = bookNumbers;
            Price = chosenBook.SellPrice;
            ChosenBook = chosenBook ?? throw new ArgumentNullException(nameof(chosenBook));
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Price < 0)
            {
                yield return new ValidationResult($"This book '{ChosenBook.Title}' is not for sale");
            }
            if (BookNumbers > 100)
            {
                yield return new ValidationResult("If you want to order more than 100 book, please contact our sales manager on 12345", new[] { nameof(BookNumbers) });
            }
        }
    }
}
