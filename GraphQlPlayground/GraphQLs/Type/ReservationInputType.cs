using GraphQL.Types;

namespace GraphQlPlayground.GraphQLs.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("specialRequest");
            Field<IntGraphType>("partySize");
            Field<StringGraphType>("phoneNumber");
            Field<DateGraphType>("reservationDate");
        }
    }
}
