using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
  public class AccountViewModel
  {
    [Required]
    public string Name { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string PhoneNum { get; set; }
    public string Address { get; set; }
    
    public bool IsUser { get; set; }
  }
}
