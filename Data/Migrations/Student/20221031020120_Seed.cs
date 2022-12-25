using Microsoft.EntityFrameworkCore.Migrations;

namespace Assign1.Data.Migrations.Student
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CityOfResidence = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[,]
                {
                    { 1, "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing" },
                    { 2, "Surrey", "jane@douglas.com", "Jane", "Douglas", "604-123-4567", "Nursing" },
                    { 3, "Vancouver", "tom@gardner.com", "Tom", "Gardner", "604-123-4567", "Welding" },
                    { 4, "Vancouver", "ann@lee.com", "Ann", "Lee", "604-123-4567", "Dentistry" },
                    { 5, "Chilliwack", "james@jones.com", "James", "Jones", "604-123-4567", "Nursing" },
                    { 6, "Surrey", "susan@taylor.com", "Susan", "Taylor", "604-123-4567", "Hospitality" },
                    { 7, "Vancouver", "peter@white.com", "Peter", "White", "604-123-4567", "Welding" },
                    { 8, "Vancouver", "philip@fox.com", "Philip", "Fox", "604-123-4567", "Dentistry" },
                    { 9, "Chilliwack", "donna@ray.com", "Donna", "Ray", "604-123-4567", "Nursing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
