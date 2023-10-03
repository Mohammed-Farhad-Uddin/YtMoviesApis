using System.ComponentModel.DataAnnotations;

namespace YtMoviesApis.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }

    }
}
