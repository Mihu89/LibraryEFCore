using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.PublishedOn).HasColumnType("date");
            builder.Property(x => x.SellPrice).HasColumnType("decimal(9,2)");
            builder.Property(x => x.ImageUrl).IsUnicode(false);
            builder.HasIndex(x => x.PublishedOn);
            builder.HasIndex(x => x.SellPrice);

            builder.HasMany(r=> r.Reviews).WithOne().HasForeignKey(x => x.BookId);
            builder.Metadata.FindNavigation(nameof(Book.Reviews)).SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
