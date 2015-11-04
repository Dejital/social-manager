using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SocialManager.Models
{
    public class SocialManagerContextInitializer : DropCreateDatabaseAlways<SocialManagerContext>
    {
        protected override void Seed(SocialManagerContext context)
        {
            var people = new List<Person>
            {
                new Person() {FirstName = "Rachel", LastName = "Green"},
                new Person() {FirstName = "Monica", LastName = "Geller"},
                new Person() {FirstName = "Phoebe", LastName = "Buffay"},
                new Person() {FirstName = "Joey", LastName = "Tribbiani"},
                new Person() {FirstName = "Chandler", LastName = "Bing"},
                new Person() {FirstName = "Ross", LastName = "Geller"},
            };
            context.People.AddRange(people);
            context.SaveChanges();

            var rachel = people[0];
            var meeting = new Meeting() {MeetingDateTime = new DateTime(2015, 11, 3)};
            var notes = new List<Note>()
            {
                new Note() {Name = "Fashion enthusiast"},
                new Note() {Name = "Dating Ross Geller"},
                new Note() {Name = "Works as waitress"},
            };

            context.Meetings.Add(meeting);
            context.Notes.AddRange(notes);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}