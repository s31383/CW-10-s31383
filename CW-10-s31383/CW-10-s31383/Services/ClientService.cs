using CW_10_s31383.Exceptions;
using CW_10_s31383.Repositories;
namespace CW_10_s31383.Services;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public async Task DeleteClient(int clientId)
    {
        if (clientRepository.HasTripsAsync(clientId))
            throw new ClientHasTripsException(clientId);
        await clientRepository.DeleteClientsAsync(clientId);
    }
}