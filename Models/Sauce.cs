using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Sauce
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100, ErrorMessage = "Maximum length")]
    public string? Name { get; set; }

    public bool IsVegan { get; set; }
}