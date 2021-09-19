using API.Entitites;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.EFCore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Job> Jobs { get; set; }
        }
    }
}
