using GraphQlPlayground.Models;

namespace GraphQlPlayground.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(int id, Category category);
        void DeleteCategory(int id);
    }
}
