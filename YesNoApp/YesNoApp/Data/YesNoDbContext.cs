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
        public YesNoDbContext(DbContextOptions<YesNoDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YesNo>().HasData(
                new YesNo
                {
                    ID = 1,
                    YesOrNo = "Yes",
                    Gif = "https://media3.giphy.com/media/SXOZY9erxavfELiyqv/200.gif",
                },

                new YesNo
                {
                    ID = 2,
                    YesOrNo = "Yes",
                    Gif = "https://media4.giphy.com/media/LSvB8JdEf4yascdXf1/200.gif",
                },
                new YesNo
                {
                    ID = 3,
                    YesOrNo = "Yes",
                    Gif = "https://viralviralvideos.com/wp-content/uploads/2015/10/Oh-yes-GIF.gif",
                },
                new YesNo
                {
                    ID = 4,
                    YesOrNo = "Yes",
                    Gif = "https://media1.giphy.com/media/3o6Yg0PuNRutL82zHW/200.gif",
                },
                new YesNo
                {
                    ID = 5,
                    YesOrNo = "Yes",
                    Gif = "https://media.tenor.com/images/e7776abf34c8e4eb31af76929d945a12/tenor.gif",
                },


    }
}
