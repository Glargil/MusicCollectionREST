using Microsoft.AspNetCore.Mvc;
using MusicCollectionREST.Repos;
using MusicCollectionREST.Models;
using Microsoft.AspNetCore.Authorization;

namespace MusicCollectionREST.Controllers
{
    [Route("api/[controller]")]
    public class RecordController : Controller
    {
        private readonly IRecordRepo _recordRepoDatabase;

        public RecordController(IRecordRepo recordRepo)
        {
            _recordRepoDatabase = recordRepo;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult GetAll(
            [FromQuery] string artist,
            [FromQuery] string title
            )
        {
            IEnumerable<Record>? result = _recordRepoDatabase.GetAll(title, artist);
            if (result == null || !result.Any())
            {
                return NoContent();
            }
            return Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Record> Add([FromBody] Record record)
        {
            Record? result = _recordRepoDatabase.Add(record);
            if (result == null)
            {
                return BadRequest();
            }
            return Created($"api/record/{record.Id}", record);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public ActionResult<Record> Delete(int id)
        {
            Record? result = _recordRepoDatabase.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public ActionResult<Record> Update(int id, [FromBody] Record record)
        {
            Record? result = _recordRepoDatabase.Update(id, record);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
}
