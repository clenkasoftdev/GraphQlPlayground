using GraphQlPlayground.Data;
using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.Services
{
    public class MenuRepository : IMenuRepository
    {
       

        private GraphQlPlaygroundDbContext _dbContext;

        public MenuRepository(GraphQlPlaygroundDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Menu> GetAllMenus()
        {
           return _dbContext.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            return _dbContext.Menus.Find(id);
        }

        public Menu GetMenuByName(string name)
        {
            return _dbContext.Menus.Where(x => x.Name == name).FirstOrDefault();
        }


        public Menu AddMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        public Menu UpdateMenu(int id, Menu menu)
        {
            
            var menuToUpdate = _dbContext.Menus.Find(id);
            menuToUpdate.Name = menu.Name;
            menuToUpdate.Description = menu.Description;
            menuToUpdate.Price = menu.Price;
            _dbContext.Menus.Update(menuToUpdate);
            _dbContext.SaveChanges();
            return menuToUpdate;
            
        }

        public void DeleteMenu(int id)
        {
            var menuToDelete = _dbContext.Menus.Find(id);
            _dbContext.Menus.Remove(menuToDelete);
            _dbContext.SaveChanges();
           
        }
    }
}
