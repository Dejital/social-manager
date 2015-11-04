using System;
using System.Collections.Generic;

namespace SocialManager.Models
{
    public class Meeting
    {
        public Meeting()
        {
            Notes = new List<Note>();
        }

        public int Id { get; set; }
        public DateTime MeetingDateTime { get; set; }

        public int PersonId { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual Person Person { get; set; }
    }
}
