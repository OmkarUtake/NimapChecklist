﻿        using System.Data.Entity;

namespace DataAnnotations
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)    
        {
            modelBuilder.Entity<Course>()
                .Property(x => x.Name).IsRequired().HasMaxLength(151);

            modelBuilder.Entity<Course>().Property(x => x.Description).IsRequired().HasMaxLength(191);

            base.OnModelCreating(modelBuilder);
        }

    }
}