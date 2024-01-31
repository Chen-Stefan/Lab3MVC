using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;

public class City
{
    [Key]
    public int CityId { get; set; }

    [Display(Name = "City")]
    public string? CityName { get; set; }
    public int? Population { get; set; }

    [Required]
    public string? ProvinceCode { get; set; }

    [ForeignKey("ProvinceCode")]
    public Province? Province { get; set; }
}
