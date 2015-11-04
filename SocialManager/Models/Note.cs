namespace SocialManager.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PersonId { get; set; }
        public int MeetingId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
