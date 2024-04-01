using GraphQL;
using GraphQL.Types;
using GraphQlPlayground.GraphQLs.Type;
using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.GraphQLs.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenuRepository menuRepository)
        {
            Field<MenuType>("CreateMenu").Arguments(new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(ctx =>
            {
                var menu = ctx.GetArgument<Menu>("menu");
                return menuRepository.AddMenu(menu);
            });

            Field<MenuType>("UpdateMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" },
                new QueryArgument<MenuInputType> { Name = "menu" })).Resolve(ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                var menu = ctx.GetArgument<Menu>("menu");
                return menuRepository.UpdateMenu(id,menu);
            });

            Field<StringGraphType>("DeleteMenu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" })).Resolve(ctx =>
            {
                var id = ctx.GetArgument<int>("id");
                menuRepository.DeleteMenu(id);
                return $"Menu with id {id} is deleted";
            });
        }
    }
}
