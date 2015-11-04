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
            var rachel = people[0];

            var meeting = new Meeting() {MeetingDateTime = new DateTime(2015, 11, 3)};

            var noteTags = new List<NoteTag>()
            {
                new NoteTag() {Tag = "Fashion enthusiast"},
                new NoteTag() {Tag = "Dating Ross Geller"},
                new NoteTag() {Tag = "Works as waitress"},
            };

            var notes = new List<Note>();
            noteTags.ForEach(t => notes.Add(new Note() { NoteTag = t, Person = rachel}));

            notes.ForEach(n => rachel.Notes.Add(n));
            rachel.Meetings.Add(meeting);

            context.People.AddRange(people);
            context.Meetings.Add(meeting);
            context.NoteTags.AddRange(noteTags);
            context.Notes.AddRange(notes);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}