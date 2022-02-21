using AutoMapper;
using InteractiveMap.Entities;
using InteractiveMap.Exceptions;
using InteractiveMap.Models;
using Microsoft.EntityFrameworkCore;

namespace InteractiveMap.Services
{
    public interface IMarkerService
    {
        IEnumerable<MarkerDto> GetAllMarkers();
        MarkerDto GetMarkerById(int id);
        int CreateMarker(CreateMarkerDto markerDto);
        void DeleteMarker(int id);

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

        public MarkerDto GetMarkerById(int id)
        {
            var marker = _dbContext.Markers
                .Include(u => u.User)
                .Include(c => c.Comments)
                .ThenInclude(u => u.User)
                .FirstOrDefault(m => m.Id == id);
            if (marker is null)
                throw new NotFoundExcepiton($"Marker with id: {id} not found");

            var result = _mapper.Map<MarkerDto>(marker); 

            return result;
            
        }

        public int CreateMarker(CreateMarkerDto markerDto)
        {
            var marker = _mapper.Map<Marker>(markerDto);
            _dbContext.Add(marker);
            _dbContext.SaveChanges();

            return marker.Id;
        }

        public void DeleteMarker(int id)
        {
            var marker = _dbContext.Markers
                .FirstOrDefault(m => m.Id == id);

            if(marker is null)
                throw new NotFoundExcepiton($"Marker with id: {id} not found");

            _dbContext.Remove(marker);
            _dbContext.SaveChanges();
        }
    }


}
