using System.ComponentModel.DataAnnotations;

namespace Lab3.Models;

public class Province
{
    [Key]
    [Display(Name = "Province Code")]
    public string? ProvinceCode { get; set; }
    [Display(Name = "Province")]
    public string? ProvinceName { get; set; }
    public List<City>? Cities { get; set; }
}
