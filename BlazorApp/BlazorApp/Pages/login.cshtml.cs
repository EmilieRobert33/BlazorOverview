using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp.Pages
{
    public class loginModel : PageModel
    {
        public async Task OnGet(string redirectUri)
        {
            await HttpContext.ChallengeAsync("Auth0", new AuthenticationProperties
            {
                RedirectUri = redirectUri
            });
        }
    }
}
