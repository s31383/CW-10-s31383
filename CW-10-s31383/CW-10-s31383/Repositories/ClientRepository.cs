using CW_10_s31383.Data;
using CW_10_s31383.Exceptions;
namespace CW_10_s31383.Repositories;

public class ClientRepository(AppDbContext dbContext) : IClientRepository
{
    public bool HasTripsAsync(int clientId)
    {
        return dbContext.ClientTrips.FirstOrDefault(clientTrip => clientTrip.IdClient == clientId) != null;
    }

    public async Task DeleteClientsAsync(int clientId)
    {
        var client = dbContext.Clients.FirstOrDefault(client => client.IdClient == clientId);
        dbContext.Clients.Remove(client ?? throw new ClientNotExistsException(clientId));
        await dbContext.SaveChangesAsync();
    }
}