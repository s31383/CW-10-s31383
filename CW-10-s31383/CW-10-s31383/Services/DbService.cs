using CW_10_s31383.Data;
using CW_10_s31383.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CW_10_s31383.Services;

public class DbService(AppDbContext dbContext) : IDbService
{
    public async Task<IEnumerable<TripGetDto>> GetSortedTripsAsync(int page, int pageSize)
    {
        return (await dbContext.Trips.ToListAsync()).Select(trip => new TripGetDto
            {
                IdTrip = trip.IdTrip,
                DateFrom = trip.DateFrom,
                DateTo = trip.DateTo,
                Description = trip.Description,
                MaxPeople = trip.MaxPeople,
                Name = trip.Name
            })
            .OrderBy(tripDto => tripDto.DateFrom)
            .Take(new Range(pageSize* page-1,pageSize*page)); 
    }
}