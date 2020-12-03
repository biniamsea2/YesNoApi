using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YesNoApp.Models;

namespace YesNoApp.Data
{
    public class YesNoDbContext : DbContext
    {
        protected YesNoDbContext(DbContextOptions<YesNoDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YesNo>().HasData(
                new YesNo
                {
                    ID = 1,
                    YesOrNo = "Yes",
                    Meme = "Test",
                });
        }
        public DbSet<YesNo> YesNoTable { get; set; }

    }
}
