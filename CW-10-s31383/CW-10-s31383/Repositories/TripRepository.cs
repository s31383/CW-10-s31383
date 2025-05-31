using System.Collections;
using CW_10_s31383.Data;
using CW_10_s31383.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CW_10_s31383.Repositories;

public class TripRepository(AppDbContext dbContext) : ITripRepository
{
    public async Task<IEnumerable<TripGetDto>> GetSortedTripsAsync(int page, int pageSize)
    {
        return (await dbContext.Trips.Include(trip => trip.IdCountries).ToListAsync()).Select(trip =>
            {
                var tripDto = new TripGetDto
                {
                    IdTrip = trip.IdTrip,
                    DateFrom = trip.DateFrom,
                    DateTo = trip.DateTo,
                    Description = trip.Description,
                    MaxPeople = trip.MaxPeople,
                    Name = trip.Name,
                    Countries = []
                };
                foreach (var country in trip.IdCountries)
                {
                    tripDto.Countries.Add(new TripGetDtoCountry
                    {
                        Id = country.IdCountry,
                        Name = country.Name
                    });
                }

                return tripDto;
            })
            .OrderBy(tripDto => tripDto.DateFrom)
            .Take(new Range(pageSize* page-1,pageSize*page)); 
    }
}