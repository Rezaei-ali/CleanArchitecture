using Cms.Core.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;


    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
    {
        return Ok(_categoryRepository.GetById(id));
    }
    
    [HttpGet]
    public IActionResult GetAllCategory()
    {
        return Ok(_categoryRepository.GetAll());
    }
    
}