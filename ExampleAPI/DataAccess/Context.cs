using ExampleAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAPI.DataAccess
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>opt):base(opt)
        {

        }
        public DbSet<Posts> Posts { get; set; }
    }
}
