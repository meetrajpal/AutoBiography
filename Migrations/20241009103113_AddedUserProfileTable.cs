using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoBiography.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserProfileTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URI",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PicUri = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1674110958136-40fd83adc9e3?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1536721572694-0b9bc1bb6946?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1712885046114-5ea81a2f7555?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1714008384412-97137b26ab42?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1722385640799-4ee84eb90038?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw1fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1706082072635-d19df8f0f3fb?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1712815780855-5cce5961f8ba?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw3fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1711523164285-71e1dbb948ca?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw4fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1717032676227-aceed0508f1e?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw5fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1699506612941-9282c50c374d?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDEyOXww&ixlib=rb-4.0.3" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1719970680701-9c9f5c3ff8b0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1705563666935-4d0a72709948?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1622058232252-a8657f5b2979?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198463-cdf3e40e023b?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198307-645561899472?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663197379-2591b57c834c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198293-d06df57687ac?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198608-7116ee7596cd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663197413-c082e7d4af12?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663197869-e9f75851f2bd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198393-ed1cd802f093?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198373-c38cfe4d99ff?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198662-f50225e030c7?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198367-8ceb51fa89f0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198263-9984f048d3ea?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1720590509047-4bd0591aaf13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198707-d5d3ff6e963d?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198423-1c114d0294a0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1622058232222-2700277d1a56?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198736-4e84796803db?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198451-b66759d9ff3c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663197359-33f219b018c1?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663197411-2ba61f5f4961?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1725885970369-884a996b638c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198575-136cb08edd8e?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1698663198546-b72850b1e84a?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1646283181928-59e4244eb1e8?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1709104761873-24cc12d23b28?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1682570965698-9eb843b9bd13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Title", "URI" },
                values: new object[] { null, "https://images.unsplash.com/photo-1706752986827-f784d768d4c3?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0MHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "URI",
                table: "Gallery");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "https://images.unsplash.com/photo-1674110958136-40fd83adc9e3?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "https://images.unsplash.com/photo-1536721572694-0b9bc1bb6946?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "https://images.unsplash.com/photo-1712885046114-5ea81a2f7555?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzfHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "https://images.unsplash.com/photo-1714008384412-97137b26ab42?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "https://images.unsplash.com/photo-1722385640799-4ee84eb90038?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw1fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "https://images.unsplash.com/photo-1706082072635-d19df8f0f3fb?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw2fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "https://images.unsplash.com/photo-1712815780855-5cce5961f8ba?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw3fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "https://images.unsplash.com/photo-1711523164285-71e1dbb948ca?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw4fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "https://images.unsplash.com/photo-1717032676227-aceed0508f1e?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw5fHxjYXIlMjBzdHVkaW8lMjB3YWxscGFwZXJ8ZW58MHx8fHwxNzI4NDY0MTI5fDA&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "https://images.unsplash.com/photo-1699506612941-9282c50c374d?ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDEyOXww&ixlib=rb-4.0.3");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 11,
                column: "Title",
                value: "https://images.unsplash.com/photo-1719970680701-9c9f5c3ff8b0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 12,
                column: "Title",
                value: "https://images.unsplash.com/photo-1705563666935-4d0a72709948?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 13,
                column: "Title",
                value: "https://images.unsplash.com/photo-1622058232252-a8657f5b2979?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 14,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198463-cdf3e40e023b?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 15,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198307-645561899472?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 16,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663197379-2591b57c834c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 17,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198293-d06df57687ac?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 18,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198608-7116ee7596cd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 19,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663197413-c082e7d4af12?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwxOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 20,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663197869-e9f75851f2bd?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDI1Mnww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 21,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198393-ed1cd802f093?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 22,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198373-c38cfe4d99ff?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 23,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198662-f50225e030c7?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 24,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198367-8ceb51fa89f0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 25,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198263-9984f048d3ea?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 26,
                column: "Title",
                value: "https://images.unsplash.com/photo-1720590509047-4bd0591aaf13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 27,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198707-d5d3ff6e963d?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 28,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198423-1c114d0294a0?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwyOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 29,
                column: "Title",
                value: "https://images.unsplash.com/photo-1622058232222-2700277d1a56?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 30,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198736-4e84796803db?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDM5OXww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 31,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198451-b66759d9ff3c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 32,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663197359-33f219b018c1?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzMnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 33,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663197411-2ba61f5f4961?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzM3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 34,
                column: "Title",
                value: "https://images.unsplash.com/photo-1725885970369-884a996b638c?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 35,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198575-136cb08edd8e?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 36,
                column: "Title",
                value: "https://images.unsplash.com/photo-1698663198546-b72850b1e84a?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzNnx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 37,
                column: "Title",
                value: "https://images.unsplash.com/photo-1646283181928-59e4244eb1e8?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzN3x8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 38,
                column: "Title",
                value: "https://images.unsplash.com/photo-1709104761873-24cc12d23b28?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 39,
                column: "Title",
                value: "https://images.unsplash.com/photo-1682570965698-9eb843b9bd13?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHwzOXx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "Id",
                keyValue: 40,
                column: "Title",
                value: "https://images.unsplash.com/photo-1706752986827-f784d768d4c3?crop=entropy&cs=srgb&fm=jpg&ixid=M3w1NTk2NzB8MHwxfHNlYXJjaHw0MHx8Y2FyJTIwc3R1ZGlvJTIwd2FsbHBhcGVyfGVufDB8fHx8MTcyODQ2NDg1MHww&ixlib=rb-4.0.3&q=85");
        }
    }
}
