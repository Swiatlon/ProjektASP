using Data;
using Microsoft.AspNetCore.Mvc;

[Route("api/producers")]
[ApiController]
public class ProducerApiController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProducerApiController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetFiltered(string filter)
    {
        var filteredProducers = _context.Producers
            .Where(p => p.Name.ToLower().StartsWith(filter.ToLower()))
            .Select(p => new { p.Id, p.Name, p.Description })
            .ToList();

        return Ok(filteredProducers);
    }
}