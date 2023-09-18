using Cms.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostRepository _postRepository;

    public PostController(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }
    [HttpGet("GetLatestPosts")]
    public IActionResult GetLatestPosts()
    {
        return Ok(_postRepository.GetLatestPosts(10));
        
    }



    
    
    
}