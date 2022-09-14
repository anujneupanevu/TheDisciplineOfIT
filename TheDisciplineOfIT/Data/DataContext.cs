using System;
using Microsoft.EntityFrameworkCore;
using TheDisciplineOfIT.Models;

namespace TheDisciplineOfIT.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<Courses> Courses { get; set; }


    }
}
