using CW_10_s31383.Exceptions;
using CW_10_s31383.Services;
using Microsoft.AspNetCore.Mvc;

namespace CW_10_s31383.Controllers;

[ApiController]
[Route("api/clients")]
public class ClientController(IClientService clientService) : ControllerBase
{
    [HttpDelete("/{idClient}")]
    public async Task<IActionResult> DeleteClient(int idClient)
    {
        try
        {
            await clientService.DeleteClient(idClient);
            return Ok();
        }
        catch (ClientNotExistsException clientNotExistsException)
        {
            return NotFound(clientNotExistsException.Message);
        }
        catch (ClientHasTripsException clientHasTripsException)
        {
            return BadRequest(clientHasTripsException.Message);
        }
    }
}