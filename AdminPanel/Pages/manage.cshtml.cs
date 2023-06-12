using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace AdminPanel.Pages
{
    [Authorize]
    public class manageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
