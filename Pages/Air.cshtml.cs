using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace air_object_movements_net_core.Pages;


public class AirModel : PageModel
{
    private readonly ILogger<AirModel> _logger;

    public AirModel(ILogger<AirModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {

    }
}
