namespace SocialManager.Models
{
    public class NoteTag
    {
        public NoteTag(string tag)
        {
            Tag = tag;
        }

        public int Id { get; set; }
        public string Tag { get; private set; }
    }
}