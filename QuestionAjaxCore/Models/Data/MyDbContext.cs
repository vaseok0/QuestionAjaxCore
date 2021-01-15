using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionAjaxCore.Models.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
