using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo3
{
    public class ApplicationDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\mssqllocaldb; Initial Catalog= PruebaEF; Integrated Security=True")
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(myLoggerFactory);
            base.OnConfiguring(options);
        }
        public static readonly ILoggerFactory myLoggerFactory = LoggerFactory.Create(x =>
             x.AddFilter((category, level) =>
                 category == DbLoggerCategory.Database.Command.Name
             && level == LogLevel.Information));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>().Property(x => x.Nombre).HasField("_nombre");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public static ILoggerFactory MyLoggerFactory => myLoggerFactory;
    }
}
