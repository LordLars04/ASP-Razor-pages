using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Control
    {
        [Required(ErrorMessage = "Namn är obligatoriskt.")]
        [StringLength(100, ErrorMessage = "Namnet får vara högst 100 tecken långt.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "E-post är obligatoriskt.")]
        [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
        public string? Email { get; set; }
    }
}