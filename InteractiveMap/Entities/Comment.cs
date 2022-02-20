namespace InteractiveMap.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public decimal AuthorRate { get; set; }
        public int MarkerId { get; set; }
        public virtual Marker Marker { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }  
    }
}