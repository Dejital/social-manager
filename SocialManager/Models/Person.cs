using System.Collections.Generic;

namespace SocialManager.Models
{
    public class Person
    {
        public Person()
        {
            Meetings = new List<Meeting>();
            Notes = new List<Note>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}