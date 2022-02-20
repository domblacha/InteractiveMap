namespace InteractiveMap.Models
{
    public class MarkerDto
    {
        public int MarkerId { get; set; }
        public string PointName { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
