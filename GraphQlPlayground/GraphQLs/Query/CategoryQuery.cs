using GraphQL;
using GraphQL.Types;
using GraphQlPlayground.GraphQLs.Type;
using GraphQlPlayground.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace GraphQlPlayground.GraphQLs.Query
{
    public class CategoryQuery: ObjectGraphType
    {
        public CategoryQuery(ICategoryRepository categoryRepository)
        {            
            Field<ListGraphType<CategoryType>>("Categories").Resolve(ctx =>
            {
                   return categoryRepository.GetAllCategories();
            });


        }   
    }
}
