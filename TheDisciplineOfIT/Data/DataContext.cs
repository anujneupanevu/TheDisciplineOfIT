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

        public DbSet<Students> Student { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Resources> Resource { get; set; }
        public DbSet<Teachers> Teacher { get; set; }
        public DbSet<Units> Unit { get; set; }
        public DbSet<Courses> Course { get; set; }


    }
}
