
using GraphQlPlayground.GraphQLs.Mutation;
using GraphQlPlayground.GraphQLs.Query;

namespace GraphQlPlayground.GraphQLs.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(MenuQuery menuQuery, MenuMutation menuMutation)
        {
            Query = menuQuery;
            Mutation = menuMutation;
        }
    }
}
