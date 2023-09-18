using Cms.Core.Domains;

namespace Cms.Core.Interfaces.Repository;

public interface ICategoryRepository
{
    Category GetById(int id);
    List<Category> GetAll();
    int Add(Category category);
    void Edit(Category category);
    void Delete(int id);
}