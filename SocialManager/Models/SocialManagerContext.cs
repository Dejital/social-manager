﻿using System.Data.Entity;

namespace SocialManager.Models
{
    public class SocialManagerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SocialManagerContext() : base("name=SocialManagerContext")
        {
        }

        public DbSet<Person> People { get; set; }
    
        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<NoteTag> NoteTags { get; set; }
    }
}
