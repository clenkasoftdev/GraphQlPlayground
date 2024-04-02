using GraphQlPlayground.Data;
using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlPlayground.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private GraphQlPlaygroundDbContext _dbContext;

        public CategoryRepository(GraphQlPlaygroundDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Category AddCategory(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var catToDelete = _dbContext.Categories.Find(id);
            _dbContext.Categories.Remove(catToDelete);
            _dbContext.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _dbContext.Categories.ToList();
        }

        public Category UpdateCategory(int id, Category category)
        {
            var catToUpdate = _dbContext.Categories.Find(id);
            catToUpdate.Name = category.Name;
            catToUpdate.ImageUrl = category.ImageUrl;

            _dbContext.Categories.Update(catToUpdate);
            _dbContext.SaveChanges();
            return catToUpdate;
        }
    }
}
