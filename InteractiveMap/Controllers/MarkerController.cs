using InteractiveMap.Models;
using InteractiveMap.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMap.Controllers
{
    [Route("api/marker")]
    [ApiController]
    public class MarkerController : ControllerBase
    {
        private readonly IMarkerService _markerService;

        public MarkerController(IMarkerService markerService)
        {
            _markerService = markerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MarkerDto>> GetAllMarkers()
        {
            var result = _markerService.GetAllMarkers();

            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult<MarkerDto> GetMarkerById([FromRoute] int id)
        {
            var result = _markerService.GetMarkerById(id);

            return Ok(result);
        }
        [HttpPost]
        public ActionResult CreateMarker([FromBody] CreateMarkerDto markerDto)
        {
            var markerId = _markerService.CreateMarker(markerDto);

            return Created($"api/marker/{markerId}", null);

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteMarker([FromRoute] int id)
        {
            _markerService.DeleteMarker(id);

            return NoContent();
        }
    }
}
