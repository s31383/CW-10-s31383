using CW_10_s31383.DTOs;

namespace CW_10_s31383.Services;

public interface ITripService
{
    public Task<IEnumerable<TripGetDto>> GetSortedTripsAsync(int page, int pageSize = 10);
}