using GraphQL.Types;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.GraphQLs.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
            Field(x => x.Price);
        }
    }
}
