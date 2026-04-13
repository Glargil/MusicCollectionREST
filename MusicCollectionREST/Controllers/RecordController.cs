using Microsoft.AspNetCore.Mvc;
using MusicCollectionREST.Repos;
using MusicCollectionREST.Models;

namespace MusicCollectionREST.Controllers
{
    [Route("api/[controller]")]
    public class RecordController : Controller
    {
        private readonly IRecordRepo _recordRepo;

        public RecordController(IRecordRepo recordRepo)
        {
            _recordRepo = recordRepo;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public IActionResult GetAll(
            [FromQuery] string artist,
            [FromQuery] string title
            )
        {
            IEnumerable<Record>? result = _recordRepo.GetAll(title, artist);
            if (result == null || !result.Any())
            {
                return NoContent();
            }
            return Ok(result);
        }

    }
}
