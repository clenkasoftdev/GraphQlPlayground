using GraphQlPlayground.Models;

namespace GraphQlPlayground.Interfaces
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenus();
        Menu GetMenuById(int id);
        Menu GetMenuByName(string name);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu);
        void DeleteMenu(int id);


    }
}
