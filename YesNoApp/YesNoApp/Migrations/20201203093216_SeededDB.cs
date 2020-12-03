using Microsoft.EntityFrameworkCore.Migrations;

namespace YesNoApp.Migrations
{
    public partial class SeededDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YesNoTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YesOrNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gif = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesNoTable", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "YesNoTable",
                columns: new[] { "ID", "Gif", "YesOrNo" },
                values: new object[,]
                {
                    { 1, "https://media3.giphy.com/media/SXOZY9erxavfELiyqv/200.gif", "Yes" },
                    { 2, "https://media4.giphy.com/media/LSvB8JdEf4yascdXf1/200.gif", "Yes" },
                    { 3, "https://viralviralvideos.com/wp-content/uploads/2015/10/Oh-yes-GIF.gif", "Yes" },
                    { 4, "https://media1.giphy.com/media/3o6Yg0PuNRutL82zHW/200.gif", "Yes" },
                    { 5, "https://media.tenor.com/images/e7776abf34c8e4eb31af76929d945a12/tenor.gif", "Yes" },
                    { 6, "https://media4.giphy.com/media/JYZ397GsFrFtu/200.gif", "No" },
                    { 7, "https://media4.giphy.com/media/LOEI8jsNKPmzdJYvhJ/200.gif", "No" },
                    { 8, "https://media1.tenor.com/images/b6219b2a69b5e209dc394a01d3de61c7/tenor.gif?itemid=12337588", "No" },
                    { 9, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoBLh_8czGn-xQXpPyjPKAG0ZnH9OUjB4uKw&usqp=CAU", "No" },
                    { 10, "https://media0.giphy.com/media/YOkrK8agZLEk2cXeLi/200.gif", "No" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YesNoTable");
        }
    }
}
