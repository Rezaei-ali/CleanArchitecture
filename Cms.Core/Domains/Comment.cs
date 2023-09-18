namespace Cms.Core.Domains;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime CreateDate { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
}