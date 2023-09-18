using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Infrastructure.Data.Entities;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreateDate { get; set; }
}


public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Title).HasMaxLength(50);
    }
}

