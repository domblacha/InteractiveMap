namespace InteractiveMap.Entities
{
    public class Marker
    {
        public int Id { get; set; }
        public string PointName { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}

