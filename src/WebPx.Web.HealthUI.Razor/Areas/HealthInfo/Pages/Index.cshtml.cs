using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebPx.Web.HealthUI.Razor.Areas.HealthInfo.Pages
{
    /// <summary>
    /// Class for the Index page model of the HealthInfo Razor Pages
    /// </summary>
    public class IndexModel : PageModel
    {
        private HealthReport? _report;

        /// <summary>
        /// Gets the <seealso cref="HealthReport"/> from the <seealso cref="HealthCheckService"/>
        /// </summary>
        public HealthReport? Report => _report;

        /// <summary>
        /// Method to handle the GET request
        /// </summary>
        /// <returns>Returns and Action Result</returns>
        public async Task<IActionResult> OnGetAsync()
        {
            var healthCheckService = HttpContext.RequestServices.GetRequiredService<HealthCheckService>();
            _report = await healthCheckService.CheckHealthAsync(HttpContext.RequestAborted);
            if (_report == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}