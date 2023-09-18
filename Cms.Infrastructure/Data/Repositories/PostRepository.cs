using Cms.Core.Domains;
using Cms.Core.Interfaces.Repository;
using System.Linq;


using PostEntity = Cms.Infrastructure.Data.Entities.Post;
using PostDomain = Cms.Core.Domains.Post;


namespace Cms.Infrastructure.Data.Repositories;

public class PostRepository : IPostRepository
{
    private readonly CmsDbContext _cmsDbContext;

    public PostRepository(CmsDbContext cmsDbContext)
    {
        _cmsDbContext = cmsDbContext;
    }
    
    public List<Post> GetLatestPosts(int count)
    {

        return _cmsDbContext.Posts.Select(x => new PostDomain
        {
            Id = x.Id,
            Title = x.Title,
            Content = x.Content,
            CreateDate = x.CreateDate

        }).Take(count).ToList();

    }
}