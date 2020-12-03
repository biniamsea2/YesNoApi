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
                new YesNo
                {
                    ID = 6,
                    YesOrNo = "No",
                    Gif = "https://media4.giphy.com/media/JYZ397GsFrFtu/200.gif",
                },
                new YesNo
                {
                    ID = 7,
                    YesOrNo = "No",
                    Gif = "https://media4.giphy.com/media/LOEI8jsNKPmzdJYvhJ/200.gif",
                },
                new YesNo
                {
                    ID = 8,
                    YesOrNo = "No",
                    Gif = "https://media1.tenor.com/images/b6219b2a69b5e209dc394a01d3de61c7/tenor.gif?itemid=12337588",
                },
                new YesNo
                {
                    ID = 9,
                    YesOrNo = "No",
                    Gif = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoBLh_8czGn-xQXpPyjPKAG0ZnH9OUjB4uKw&usqp=CAU",
                },
                new YesNo
                {
                    ID = 10,
                    YesOrNo = "No",
                    Gif = "https://media0.giphy.com/media/YOkrK8agZLEk2cXeLi/200.gif",
                });
        }

        //table
        public DbSet<YesNo> YesNoTable { get; set; }
    }
}
