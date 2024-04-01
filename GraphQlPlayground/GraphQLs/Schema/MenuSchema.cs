
using GraphQlPlayground.GraphQLs.Query;

namespace GraphQlPlayground.GraphQLs.Schema
{
    public class MenuSchema : GraphQL.Types.Schema
    {
        public MenuSchema(MenuQuery menuQuery)
        {
            Query = menuQuery;
        }
    }
}
