using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simpleWeb.Pages;

public class AboutusModel : PageModel
{
    private readonly ILogger<AboutusModel> _logger;

    public AboutusModel(ILogger<AboutusModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
