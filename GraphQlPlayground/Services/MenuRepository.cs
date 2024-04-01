using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.Services
{
    public class MenuRepository : IMenuRepository
    {
       
        private static List<Menu> _menuList = new List<Menu>
        {
            new Menu { Id = 1, Name = "Burger", Description = "Tasty Burger", Price = 10.0 },
            new Menu { Id = 2, Name = "Pizza", Description = "Cheesy Pizza", Price = 15.0 },
            new Menu { Id = 3, Name = "Pasta", Description = "Creamy Pasta", Price = 12.0 },
            new Menu { Id = 4, Name = "Sandwich", Description = "Healthy Sandwich", Price = 8.0 },
            new Menu { Id = 5, Name = "Salad", Description = "Fresh Salad", Price = 6.0 }
        };

        public List<Menu> GetAllMenus()
        {
           return _menuList;
        }

        public Menu GetMenuById(int id)
        {
            return _menuList.Find(x => x.Id == id);
        }

        public Menu GetMenuByName(string name)
        {
            return _menuList.Find(x => x.Name == name);
        }


        public Menu AddMenu(Menu menu)
        {
            _menuList.Add(menu);
            return menu;
        }

        public Menu UpdateMenu(Menu menu)
        {
            var menuToUpdate = _menuList.Find(x => x.Id == menu.Id);
            menuToUpdate.Name = menu.Name;
            menuToUpdate.Description = menu.Description;
            menuToUpdate.Price = menu.Price;
            return menuToUpdate;
            
        }

        public void DeleteMenu(int id)
        {
            var menuToDelete = _menuList.Find(x => x.Id == id);
            _menuList.Remove(menuToDelete);
           
        }
    }
}
