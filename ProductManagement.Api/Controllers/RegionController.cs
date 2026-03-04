using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class RegionController : ControllerBase
{
    private readonly RegionService _regionService;

    public RegionController(RegionService regionService)
    {
        _regionService = regionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetRegiones()
    {
        var regiones = await _regionService.GetRegiones();
        return Ok(regiones);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRegion(int id)
    {
        var region = await _regionService.GetRegion(id);
        return Ok(region);
    }
}