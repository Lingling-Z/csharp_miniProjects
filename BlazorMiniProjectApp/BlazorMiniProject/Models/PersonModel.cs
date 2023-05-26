using System.ComponentModel.DataAnnotations;

namespace BlazorMiniProject.Models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public AddressModel Address { get; set; }
    }
}
