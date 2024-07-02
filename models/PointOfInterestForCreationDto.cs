using System.ComponentModel.DataAnnotations;

namespace CityInfo.models;

public class PointOfInterestForCreationDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(200)]
    public string? Description { get; set; }
}