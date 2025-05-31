namespace CW_10_s31383.Repositories;

public interface IClientRepository
{
    bool HasTripsAsync(int clientId);
    Task DeleteClientsAsync(int clientId);
}