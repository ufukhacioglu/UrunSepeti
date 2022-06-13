using AdaYazilim.Context;
using AdaYazilim.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdaYazilim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdaYazilimController : ControllerBase
    {
        public readonly DatabaseContext _context;

        public AdaYazilimController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Test([FromQuery]int musteriAdet,[FromQuery] int sepetAdet)
        {
            BirinciService birinciService = new BirinciService(_context);
            var result = birinciService.TestVerisiOlustur(musteriAdet, sepetAdet);

            return Ok(result);



        }

        [HttpGet]
        public async Task<IActionResult> AnalizYap()
        {
            IkinciService ikinciService = new IkinciService(_context);
            var result = ikinciService.AnalizYap();

            return Ok(result);



        }

    }
}
