namespace CW_10_s31383.Exceptions;

public class ClientHasTripsException : Exception
{
    public ClientHasTripsException(int number) : base($"Client {number} Has Trips")
    {
    }
}