using CW_10_s31383.Data;
using CW_10_s31383.DTOs;
using CW_10_s31383.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CW_10_s31383.Services;

public class TripService(ITripRepository tripRepository) : ITripService
{
    public Task<IEnumerable<TripGetDto>> GetSortedTripsAsync(int page, int pageSize)
    {
        return tripRepository.GetSortedTripsAsync(page, pageSize);
    }
}