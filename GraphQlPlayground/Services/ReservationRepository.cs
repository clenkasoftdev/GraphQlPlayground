using GraphQlPlayground.Data;
using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Models;

namespace GraphQlPlayground.Services
{
    public class ReservationRepository : IReservationRepository
    {
        private GraphQlPlaygroundDbContext _dbContext;

        public ReservationRepository(GraphQlPlaygroundDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public void DeleteReservation(int id)
        {
            var toDelete = _dbContext.Reservations.Find(id);
            _dbContext.Reservations.Remove(toDelete);
            _dbContext.SaveChanges();
        }

        public List<Reservation> GetAllReservations()
        {
            return _dbContext.Reservations.ToList();
        }

        public Reservation GetReservationById(int id)
        {
            throw new NotImplementedException();
        }

        public Reservation UpdateReservation(int id, Reservation reservation)
        {
            throw new NotImplementedException();
        }
    }
}
