﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YesNoApp.Data;

namespace YesNoApp.Migrations
{
    [DbContext(typeof(YesNoDbContext))]
    [Migration("20201203093216_SeededDB")]
    partial class SeededDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("YesNoApp.Models.YesNo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Gif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YesOrNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("YesNoTable");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Gif = "https://media3.giphy.com/media/SXOZY9erxavfELiyqv/200.gif",
                            YesOrNo = "Yes"
                        },
                        new
                        {
                            ID = 2,
                            Gif = "https://media4.giphy.com/media/LSvB8JdEf4yascdXf1/200.gif",
                            YesOrNo = "Yes"
                        },
                        new
                        {
                            ID = 3,
                            Gif = "https://viralviralvideos.com/wp-content/uploads/2015/10/Oh-yes-GIF.gif",
                            YesOrNo = "Yes"
                        },
                        new
                        {
                            ID = 4,
                            Gif = "https://media1.giphy.com/media/3o6Yg0PuNRutL82zHW/200.gif",
                            YesOrNo = "Yes"
                        },
                        new
                        {
                            ID = 5,
                            Gif = "https://media.tenor.com/images/e7776abf34c8e4eb31af76929d945a12/tenor.gif",
                            YesOrNo = "Yes"
                        },
                        new
                        {
                            ID = 6,
                            Gif = "https://media4.giphy.com/media/JYZ397GsFrFtu/200.gif",
                            YesOrNo = "No"
                        },
                        new
                        {
                            ID = 7,
                            Gif = "https://media4.giphy.com/media/LOEI8jsNKPmzdJYvhJ/200.gif",
                            YesOrNo = "No"
                        },
                        new
                        {
                            ID = 8,
                            Gif = "https://media1.tenor.com/images/b6219b2a69b5e209dc394a01d3de61c7/tenor.gif?itemid=12337588",
                            YesOrNo = "No"
                        },
                        new
                        {
                            ID = 9,
                            Gif = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoBLh_8czGn-xQXpPyjPKAG0ZnH9OUjB4uKw&usqp=CAU",
                            YesOrNo = "No"
                        },
                        new
                        {
                            ID = 10,
                            Gif = "https://media0.giphy.com/media/YOkrK8agZLEk2cXeLi/200.gif",
                            YesOrNo = "No"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
