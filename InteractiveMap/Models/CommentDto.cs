namespace InteractiveMap.Models
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public decimal AuthorRate { get; set; }
    }
}
