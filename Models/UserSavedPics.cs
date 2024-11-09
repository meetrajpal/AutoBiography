using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoBiography.Models
{
    public class UserSavedPics
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(8), MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string ThumbUri { get; set; }

        [Required]
        public string FullUri { get; set; }

        [Required]
        public string Slug { get; set; }
    }
}
