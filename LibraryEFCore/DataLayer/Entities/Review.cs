using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Review
    {
        public const int NameLength = 100;
        public int Id { get; set; }
        public int BookId { get; private set; }

        [MaxLength(NameLength)]
        public string Name { get; private set; }
        public int StarRate { get; private set; }
        public string Comment { get; private set; }
        private Review() { }

        internal Review(string name, string comment,int rate, int bookId = 0) {
            Name = name;
            Comment = comment;
            StarRate = rate;
            BookId = bookId;
        }
    }
}