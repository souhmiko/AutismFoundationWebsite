using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autism.Pages
{
    public class loginModel : PageModel
    {
        public string Login { get; set; }
        public void OnGet()
        {
        }
    }
}
