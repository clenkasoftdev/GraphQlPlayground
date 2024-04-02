using GraphQL.Types;
using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.GraphQLs.Type
{
    public class CategoryType :ObjectGraphType<Category>
    { 
        public CategoryType(IMenuRepository menuRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
            Field<ListGraphType<MenuType>>("Menus").Resolve(ctx =>
            {
                return menuRepository.GetAllMenus();
            });
        }
    }
}
