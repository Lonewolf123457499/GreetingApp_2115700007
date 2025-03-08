using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositaryLayer.Entity;

namespace RepositaryLayer.Context
{
    public  class GreetingDbContext : DbContext
    {
        public GreetingDbContext(DbContextOptions<GreetingDbContext> options) : base(options)
        {
        }
        public DbSet<GreetingEntity> Greetings { get; set; }
    }
}
