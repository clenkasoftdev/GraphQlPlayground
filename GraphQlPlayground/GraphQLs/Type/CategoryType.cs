using GraphQL.Types;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.GraphQLs.Type
{
    public class CategoryType :ObjectGraphType<Category>
    { 
        public CategoryType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.ImageUrl);
        }
    }
}
