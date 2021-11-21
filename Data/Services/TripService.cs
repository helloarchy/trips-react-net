using System.Collections.Generic;
using System.Linq;
using Trips.Data.Models;

namespace Trips.Data.Services
{
    public class TripService : ITripService
    {
        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTrip(int tripId, Trip trip)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTrip(int tripId)
        {
            throw new System.NotImplementedException();
        }

        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }
    }
}