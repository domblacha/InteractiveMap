using InteractiveMap.Entities;

namespace InteractiveMap
{
    public class MapSeeder
    {
        private readonly InteractiveMapDbContext _dbContext;

        public MapSeeder(InteractiveMapDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Markers.Any())
                {
                    var markers = GetMarkers();
                    _dbContext.AddRange(markers);
                    _dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Marker> GetMarkers()
        {
            var markers = new List<Marker>()
            {
                new Marker()
                {
                    PointName = "Zamek królewski na Wawelu",
                    Description = "Wspaniałe miejsce do spędzania czasu z rodziną",
                    Rate = 5,
                    Latitude = 19,
                    Longitude = 50,
                    User = new User()
                    {
                        FirstName = "Dominik",
                        LastName = "Błacha",
                        Login = "d.blacha",
                        Password = "123",
                    },
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "Komentarz 1",
                           
                            User = new User()
                            {
                                FirstName = "Jan",
                                LastName = "Kowalski",
                                Login = "j.kowalski",
                                Password = "321",
                            },
                        }
                    }
                }
            };
            return markers;
        }
    }
}
