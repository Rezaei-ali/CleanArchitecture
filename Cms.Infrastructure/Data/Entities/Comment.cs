using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Infrastructure.Data.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreateDate { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
}

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments");
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Content).HasMaxLength(1000);

        builder.HasOne(e => e.Post).WithMany(c => c.Comments);
    }
}