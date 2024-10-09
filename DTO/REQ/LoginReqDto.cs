using System.ComponentModel.DataAnnotations;

namespace AutoBiography.DTO.REQ
{
    public class LoginReqDto
    {
        [Required]
        [MinLength(8), MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
