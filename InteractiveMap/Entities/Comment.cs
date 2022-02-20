namespace InteractiveMap.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }

        public int MarkerId { get; set; }
        public virtual Marker Marker { get; set; }
    }
}