using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPx.Web.HealthUI.Sample.Pages
{
    public class PrivacyModel(ILogger<PrivacyModel> logger) : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger = logger;

        public void OnGet()
        {
        }
    }
}

