using Cms.Core.Domains;

namespace Cms.Core.Interfaces.Repository;

public interface IPostRepository
{
    List<Post> GetLatestPosts(int count);
    
}