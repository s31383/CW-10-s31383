namespace CW_10_s31383.Controllers;
using Services;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/trips")]
public class TripController(IDbService service) : ControllerBase
{
    [HttpGet]
    public ActionResult<Task> GetTrips(int page, int pageSize = 10)
    {
        try
        {
            return service.GetSortedTripsAsync(page, pageSize);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    } 
}