using Cms.Core.Domains;
using Cms.Core.Interfaces.Repository;

using CategoryEntity = Cms.Infrastructure.Data.Entities.Category;
using CategoryDomain = Cms.Core.Domains.Category;

using System.Linq;

namespace Cms.Infrastructure.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly CmsDbContext _cmsDbContext;

    public CategoryRepository(CmsDbContext cmsDbContext)
    {
        _cmsDbContext = cmsDbContext;
    }
    
    
    public Category GetById(int id)
    {
        var item = _cmsDbContext.Categories.Select(x => new CategoryDomain
        {
            Id = x.Id,
            CreateDate = x.CreateDate

        }).FirstOrDefault(x => x.Id == id);
        
        if (item == null)
            throw new Exception("Not Found");
        
        return item;

    }

    public List<Category> GetAll()
    {
        return _cmsDbContext.Categories.Select(x => new CategoryDomain
        {
            Id = x.Id,
            CreateDate = x.CreateDate

        }).ToList();
    }

    public int Add(CategoryDomain category)
    {
        var dbModel = new CategoryEntity
        {
            Title = category.Title,
            CreateDate = category.CreateDate
        };

        _cmsDbContext.Categories.Add(dbModel);
        _cmsDbContext.SaveChanges();

        return dbModel.Id;
    }

    public void Edit(Category category)
    {
        var item = _cmsDbContext.Categories.FirstOrDefault(x => x.Id == category.Id);
        if (item == null)
            throw new Exception("Not Found");

        item.Title = category.Title;
        _cmsDbContext.Categories.Update(item);
        _cmsDbContext.SaveChanges();
    }

    
    public void Delete(int id)
    {
        var item = _cmsDbContext.Categories.FirstOrDefault(x => x.Id == id);
        if (item == null)
            throw new Exception("Not Found");
        _cmsDbContext.Remove(item);
        _cmsDbContext.SaveChanges();
        

    }
}