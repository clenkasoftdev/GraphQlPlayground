using GraphQL;
using GraphQL.Types;
using GraphQlPlayground.GraphQLs.Type;
using GraphQlPlayground.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace GraphQlPlayground.GraphQLs.Query
{
    public class MenuQuery: ObjectGraphType
    {
        public MenuQuery(IMenuRepository menuRepository)
        {            
            Field<ListGraphType<MenuType>>("Menus").Resolve(ctx =>
            {
                   return menuRepository.GetAllMenus();
            });

            Field<MenuType>("MenuById").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" })).Resolve(ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                return menuRepository.GetMenuById(id);
            });


            Field<MenuType>("MenuByName").Arguments(new QueryArguments(new QueryArgument<StringGraphType> { Name = "name" })).Resolve(ctx =>
            {
                var name = ctx.GetArgument<string>("name");
                return menuRepository.GetMenuByName(name);
            });

        }   
    }
}
