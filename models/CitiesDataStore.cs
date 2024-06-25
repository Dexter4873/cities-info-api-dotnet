namespace CityInfo.models;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }
    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>
        {
            new CityDto()
            {
                Id = 1,
                Name = "New York",
                Description = "The biggest city in the world",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Central park",
                        Description = "A big park"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Statue of liberty",
                        Description = "A huge statue of a woman"
                    }
                }
            },
            new CityDto()
            {
                Id = 2,
                Name = "Paris",
                Description = "The most beautiful city in the world",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 3,
                        Name = "Eiffel Tower",
                        Description = "A great tower in the middle of the city",
                    },
                    new PointOfInterestDto()
                    {
                        Id = 4,
                        Name = "Louvre",
                        Description = "An art museum that used to be a palace"
                    }
                }
            },
            new CityDto()
            {
                Id = 3,
                Name = "Antwerp",
                Description = "The city with the unfinished cathedral"
            }
        };
    }

}