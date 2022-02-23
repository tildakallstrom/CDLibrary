using System;
using appmom3.Models;
using Microsoft.EntityFrameworkCore;

namespace appmom3.Data
{ 
    public class CdContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public CdContext(DbContextOptions<CdContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
        public DbSet<Cd> Cd { get; set; }
        public DbSet<appmom3.Models.Artist> Artist { get; set; }
        public DbSet<appmom3.Models.Person> Person { get; set; }
        public DbSet<appmom3.Models.Borrow> Borrow { get; set; }
        public object Cds { get; internal set; }
    }
}
