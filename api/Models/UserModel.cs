using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(length:10)]
        public string FirstName { get; set; }

    }
}
