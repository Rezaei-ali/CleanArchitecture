namespace Cms.Core.Domains;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime CreateDate { get; set; }
    public string Content { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public IEnumerable<Comment> Comments { get; set; }
}