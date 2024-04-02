using GraphQL;
using GraphQL.Types;
using GraphQlPlayground.GraphQLs.Type;
using GraphQlPlayground.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace GraphQlPlayground.GraphQLs.Query
{
    public class ReservationQuery: ObjectGraphType
    {
        public ReservationQuery(IReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("Reservations").Resolve(ctx =>
            {
                return reservationRepository.GetAllReservations();
            });


        }
    }
}
