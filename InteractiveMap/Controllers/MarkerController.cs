using InteractiveMap.Models;
using InteractiveMap.Services;
using Microsoft.AspNetCore.Mvc;

namespace InteractiveMap.Controllers
{
    [Route("api/marker")]
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
    }
}
