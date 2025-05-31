namespace CW_10_s31383.Exceptions;

public class ClientNotExistsException(int number) : Exception($"Client {number} not exists")
{
}