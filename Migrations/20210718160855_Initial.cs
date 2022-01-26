using Microsoft.EntityFrameworkCore.Migrations;

namespace HW4_Ynfante.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    WeekId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(nullable: true),
                    Vs = table.Column<string>(nullable: true),
                    TeamLogo = table.Column<string>(nullable: true),
                    Opponent = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Tv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.WeekId);
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "WeekId", "Date", "Opponent", "TeamLogo", "Time", "Tv", "Vs" },
                values: new object[,]
                {
                    { 1, "Sun, Sep 12", "Indianapolis", "Indianapolis.png", "12:00 PM", "FOX", "@" },
                    { 16, "Sun, Dec 26", "Chicago", "Chicago.png", "3:05 PM", "FOX", "vs" },
                    { 15, "Sun, Dec 19", "Los Angeles", "Los Angeles.png", "3:25 PM", "FOX", "@" },
                    { 14, "Sun, Dec 12", "Houston", "Houston.png", "12:00 PM", "FOX", "@" },
                    { 13, "Sun, Dec 5", "San Francisco", "San Francisco.png", "7:20 PM", "NBC", "vs" },
                    { 12, "Mon, Nov 29", "Washington", "Washington.png", "7:15 PM", "ESPN", "@" },
                    { 11, "Sun, Nov 21", "Arizona", "Arizona.png", "3:25 PM", "FOX", "vs" },
                    { 10, "Sun, Nov 14", "Green Bay", "Green Bay.png", "3:25 PM", "CBS", "@" },
                    { 9, "BYE WEEK", "", "blank.png", "", "", "" },
                    { 8, "Sun, Oct 31", "Jacksonville", "Jacksonville.png", "3:05 PM", "CBS", "vs" },
                    { 7, "Mon, Oct 25", "New Orleans", "New Orleans.png", "7:15 PM", "ESPN", "vs" },
                    { 6, "Sun, Oct 17", "Pittsburgh", "Pittsburgh.png", "7:20 PM", "NBC", "@" },
                    { 5, "Thu, Oct 7", "Los Angeles", "Los Angeles.png", "7:20 PM", "FOX, NFL", "vs" },
                    { 4, "Sun, Oct 3", "San Francisco", "San Francisco.png", "3:05 PM", "FOX", "@" },
                    { 3, "Sun, Sep 26", "Minnesota", "Minnesota.png", "3:25 PM", "FOX", "@" },
                    { 2, "Sun, Sep 19", "Tennessee", "Tennessee.png", "3:25 PM", "CBS", "vs" },
                    { 17, "Sun, Jan 2", "Detroit", "Detroit.png", "3:25 PM", "FOX", "vs" },
                    { 18, "Sun, Jan 9", "Arizona", "Arizona.png", "3:25 PM", "FOX", "@" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
