using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.Threading.Tasks;

namespace films.Models
{
    public class FilmsContext:DbContext
    {
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmGenre> FilmGenre { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public FilmsContext(DbContextOptions<FilmsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
