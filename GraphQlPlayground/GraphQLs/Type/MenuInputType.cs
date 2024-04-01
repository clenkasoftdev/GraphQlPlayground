using GraphQL.Types;

namespace GraphQlPlayground.GraphQLs.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("description");
            Field<NonNullGraphType<FloatGraphType>>("price");
        }
    }
}
