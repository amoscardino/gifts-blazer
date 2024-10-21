using System.ComponentModel.DataAnnotations;

namespace GiftsBlazor.Models;

public class PersonDto
{
    public long Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = string.Empty;
}
