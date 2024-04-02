using GraphQlPlayground.GraphQLs.Query;

namespace GraphQlPlayground.GraphQLs.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetService<RootQuery>();
        }
    }
}
