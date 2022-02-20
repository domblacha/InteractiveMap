namespace InteractiveMap.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual List<Marker> Markers { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
