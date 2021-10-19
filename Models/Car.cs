using System.ComponentModel.DataAnnotations;

namespace GregsListDotnet.Models
{
  public class Car
  {
    public int Id { get; set; }

    [Required]
    [MinLength(3)]
    public string Make { get; set; }
    [Required]
    [MinLength(3)]
    public string Model {get; set; }
    [Required]
    [Range(1, 99999999)]
    public int Price { get; set; }
  }
}