using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models
{
    public class User
    {
        [MaxLength(18)]
        [Required]
        public string Name { get;set; }
        [EmailAddress]
        [Required]
        public string EmailAddress { get;set;}
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get;set;}

    }
}
