namespace SocialManager.Models
{
    public class Note
    {
        public int Id { get; set; }
        public NoteTag NoteTag { get; set; }
        public Person Person { get; set; }
    }
}
