using System.ComponentModel.DataAnnotations;

namespace GregsListDotnet.Models
{

  public class House 
  {
    public int Id {get; set;}

    [Required]
    [MinLength(3)]
    public string Address { get; set; }

    [Required]
    [Range(100, int.MaxValue)]
    public int Price { get; set; }
    
    [Required]
    [Range(1, int.MaxValue)]
    public int SquareFeet { get; set; }
  }
}