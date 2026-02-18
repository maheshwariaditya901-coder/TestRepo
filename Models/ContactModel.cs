using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ContactModel
    {

        [Required(ErrorMessage = "enter the first name correct ")]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "enter the Last name correct ")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
