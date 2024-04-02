using GraphQL.Types;

namespace GraphQlPlayground.GraphQLs.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery", resolve: context => new { }); // This is the entry point for the MenuQuery .. Resolve empty
            Field<CategoryQuery>("categoryQuery", resolve: context => new { });
            Field<ReservationQuery>("reservationQuery", resolve: context => new { });   
        }
    }
}
