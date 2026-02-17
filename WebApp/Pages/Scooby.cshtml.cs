using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages
{
    public class ScoobyModel : PageModel
    {
        [BindProperty]
        public InputModel Form { get; set; } = new InputModel();

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Exempelhantering: här skulle du spara eller behandla datan
            Message = $"Tack, {Form.Name}! Vi har mottagit din e-postadress {Form.Email}.";

            // Rensa formuläret efter lyckad inlämning
            Form = new InputModel();

            return Page();
        }

        public class InputModel
        {
            [Required(ErrorMessage = "Namn är obligatoriskt.")]
            [StringLength(100, ErrorMessage = "Namnet får vara högst 100 tecken långt.")]
            public string? Name { get; set; }

            [Required(ErrorMessage = "E-post är obligatoriskt.")]
            [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
            public string? Email { get; set; }
        }
    }
}
