using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Book
    {
        public const int PromotionalLength = 100;
        private HashSet<Review> _reviews;
        private HashSet<Tag> _tags;
        private Book() { }
        public Book(string title, string description, DateTime publishedOn, string publisher,
            decimal price,string imageUrl, ICollection<Author> authors,ICollection<Tag> tags)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            Title = title;
            Description = description;
            PublishedOn = publishedOn;
            Publisher = publisher;
            OriginalPrice = price;
            SellPrice = price + price*(decimal)0.25;
            ImageUrl = imageUrl;
            if (authors == null || !authors.Any())
            {
                throw new ArgumentNullException("Book should have at least one author " + nameof(authors));
            }
            _reviews = new HashSet<Review>();
            _tags = tags != null ? new HashSet<Tag>(tags) : new HashSet<Tag>();
        }
        public int Id { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Publisher { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SellPrice { get; set; }
        [MaxLength(100)]
        public string PromotionalText { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<Review> Reviews => _reviews?.ToArray();
        public IEnumerable<Tag> Tags => _tags?.ToArray();
    }
}
