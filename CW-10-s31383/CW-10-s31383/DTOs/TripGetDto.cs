namespace CW_10_s31383.DTOs;

public class TripGetDto
{
    public int IdTrip { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public int MaxPeople { get; set; }   
    public ICollection<TripGetDtoCountry> Countries { get; set; } = null!;
}

public class TripGetDtoCountry
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}