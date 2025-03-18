using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TablesAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GalleryPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    RouteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RidingExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RidingPreference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RideConsistency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommentsModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalleryPostModelId = table.Column<int>(type: "int", nullable: true),
                    RoutesModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentsModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentsModel_GalleryPosts_GalleryPostModelId",
                        column: x => x.GalleryPostModelId,
                        principalTable: "GalleryPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CommentsModel_Routes_RoutesModelId",
                        column: x => x.RoutesModelId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    RoutesModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinates_Routes_RoutesModelId",
                        column: x => x.RoutesModelId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LikesModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentsModelId = table.Column<int>(type: "int", nullable: true),
                    GalleryPostModelId = table.Column<int>(type: "int", nullable: true),
                    RoutesModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikesModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikesModel_CommentsModel_CommentsModelId",
                        column: x => x.CommentsModelId,
                        principalTable: "CommentsModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LikesModel_GalleryPosts_GalleryPostModelId",
                        column: x => x.GalleryPostModelId,
                        principalTable: "GalleryPosts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LikesModel_Routes_RoutesModelId",
                        column: x => x.RoutesModelId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentsModel_GalleryPostModelId",
                table: "CommentsModel",
                column: "GalleryPostModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentsModel_RoutesModelId",
                table: "CommentsModel",
                column: "RoutesModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinates_RoutesModelId",
                table: "Coordinates",
                column: "RoutesModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LikesModel_CommentsModelId",
                table: "LikesModel",
                column: "CommentsModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LikesModel_GalleryPostModelId",
                table: "LikesModel",
                column: "GalleryPostModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LikesModel_RoutesModelId",
                table: "LikesModel",
                column: "RoutesModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "LikesModel");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "CommentsModel");

            migrationBuilder.DropTable(
                name: "GalleryPosts");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
