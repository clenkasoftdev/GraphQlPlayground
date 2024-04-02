using GraphQlPlayground.Models;

namespace GraphQlPlayground.Interfaces
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservationById(int id);
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(int id, Reservation reservation);
        void DeleteReservation(int id);
    }
}
