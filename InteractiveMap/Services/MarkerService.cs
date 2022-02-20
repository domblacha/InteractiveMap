using AutoMapper;
using InteractiveMap.Entities;
using InteractiveMap.Models;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMap.Services
{
    public interface IMarkerService
    {
        IEnumerable<MarkerDto> GetAllMarkers();
    }
    public class MarkerService : IMarkerService
    {
        private readonly InteractiveMapDbContext _dbContext;
        private readonly IMapper _mapper;

        public MarkerService(InteractiveMapDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public IEnumerable<MarkerDto> GetAllMarkers()
        {
            var markers = _dbContext.Markers
                 .Include(m => m.User)
                 .Include(m => m.Comments)
                 .ThenInclude(m => m.User)
                 .ToList();

            var result = _mapper.Map<List<MarkerDto>>(markers);

            return result;
        }
    }


}
