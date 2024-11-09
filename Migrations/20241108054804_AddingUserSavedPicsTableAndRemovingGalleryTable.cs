using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoBiography.Migrations
{
    /// <inheritdoc />
    public partial class AddingUserSavedPicsTableAndRemovingGalleryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.CreateTable(
                name: "UserSavedPics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThumbUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSavedPics", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSavedPics");

            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "Id", "Title", "URI" },
                values: new object[,]
                {
                    { 1, null, "https://images.unsplash.com/photo-1674110958136-40fd83adc9e3?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 2, null, "https://images.unsplash.com/photo-1536721572694-0b9bc1bb6946?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 3, null, "https://images.unsplash.com/photo-1712885046114-5ea81a2f7555?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 4, null, "https://images.unsplash.com/photo-1714008384412-97137b26ab42?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 5, null, "https://images.unsplash.com/photo-1722385640799-4ee84eb90038?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw1fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 6, null, "https://images.unsplash.com/photo-1706082072635-d19df8f0f3fb?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 7, null, "https://images.unsplash.com/photo-1712815780855-5cce5961f8ba?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw3fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 8, null, "https://images.unsplash.com/photo-1711523164285-71e1dbb948ca?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw4fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 9, null, "https://images.unsplash.com/photo-1717032676227-aceed0508f1e?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw5fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" },
                    { 10, null, "https://images.unsplash.com/photo-1699506612941-9282c50c374d?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDEyOXww&ixlib=rb-4.0.3" },
                    { 11, null, "https://images.unsplash.com/photo-1719970680701-9c9f5c3ff8b0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 12, null, "https://images.unsplash.com/photo-1705563666935-4d0a72709948?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 13, null, "https://images.unsplash.com/photo-1622058232252-a8657f5b2979?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 14, null, "https://images.unsplash.com/photo-1698663198463-cdf3e40e023b?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 15, null, "https://images.unsplash.com/photo-1698663198307-645561899472?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 16, null, "https://images.unsplash.com/photo-1698663197379-2591b57c834c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 17, null, "https://images.unsplash.com/photo-1698663198293-d06df57687ac?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 18, null, "https://images.unsplash.com/photo-1698663198608-7116ee7596cd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 19, null, "https://images.unsplash.com/photo-1698663197413-c082e7d4af12?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 20, null, "https://images.unsplash.com/photo-1698663197869-e9f75851f2bd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" },
                    { 21, null, "https://images.unsplash.com/photo-1698663198393-ed1cd802f093?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 22, null, "https://images.unsplash.com/photo-1698663198373-c38cfe4d99ff?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 23, null, "https://images.unsplash.com/photo-1698663198662-f50225e030c7?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 24, null, "https://images.unsplash.com/photo-1698663198367-8ceb51fa89f0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 25, null, "https://images.unsplash.com/photo-1698663198263-9984f048d3ea?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 26, null, "https://images.unsplash.com/photo-1720590509047-4bd0591aaf13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 27, null, "https://images.unsplash.com/photo-1698663198707-d5d3ff6e963d?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 28, null, "https://images.unsplash.com/photo-1698663198423-1c114d0294a0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 29, null, "https://images.unsplash.com/photo-1622058232222-2700277d1a56?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 30, null, "https://images.unsplash.com/photo-1698663198736-4e84796803db?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" },
                    { 31, null, "https://images.unsplash.com/photo-1698663198451-b66759d9ff3c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 32, null, "https://images.unsplash.com/photo-1698663197359-33f219b018c1?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 33, null, "https://images.unsplash.com/photo-1698663197411-2ba61f5f4961?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 34, null, "https://images.unsplash.com/photo-1725885970369-884a996b638c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 35, null, "https://images.unsplash.com/photo-1698663198575-136cb08edd8e?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 36, null, "https://images.unsplash.com/photo-1698663198546-b72850b1e84a?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 37, null, "https://images.unsplash.com/photo-1646283181928-59e4244eb1e8?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 38, null, "https://images.unsplash.com/photo-1709104761873-24cc12d23b28?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 39, null, "https://images.unsplash.com/photo-1682570965698-9eb843b9bd13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" },
                    { 40, null, "https://images.unsplash.com/photo-1706752986827-f784d768d4c3?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0MHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" }
                });
        }
    }
}
