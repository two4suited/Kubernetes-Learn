using System.ComponentModel.DataAnnotations;

namespace KubeLearn.API.Controllers.Models;

public class AddPerson
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
}