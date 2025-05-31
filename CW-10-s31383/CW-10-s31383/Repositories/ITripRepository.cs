using System.Collections;
using CW_10_s31383.DTOs;

namespace CW_10_s31383.Repositories;

public interface ITripRepository
{
    Task<IEnumerable<TripGetDto>> GetSortedTripsAsync(int page, int pageSize);
}