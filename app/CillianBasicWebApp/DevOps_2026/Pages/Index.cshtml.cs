using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevOps_2026.Pages
{
    public class IndexModel : PageModel
    {
        public string Greeting { get; set; }

        public void OnGet()
        {
            Greeting = Environment.GetEnvironmentVariable("APP_GREETING") ?? "Hello World (fallback)";
        }
    }
}
