namespace SocialManager.Models
{
    public class Note
    {
        public int Id { get; set; }
        public NoteTag NoteTag { get; set; }
        public Meeting Meeting { get; set; }
        public Person Person { get; set; }
    }
}
