using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ImputacionesBackend.Migrations
{
    public partial class asdadad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "calendars",
                columns: table => new
                {
                    Calendar_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Daily_Hours = table.Column<int>(type: "int", nullable: false),
                    Monday = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Tuesday = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Wednesday = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Thursday = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Friday = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Saturday = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Sunday = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calendars", x => x.Calendar_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Role_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Role_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Employee_Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Calendar_Id = table.Column<int>(type: "int", nullable: false),
                    Role_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Employee_Id);
                    table.ForeignKey(
                        name: "FK_employees_calendars_Calendar_Id",
                        column: x => x.Calendar_Id,
                        principalTable: "calendars",
                        principalColumn: "Calendar_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_roles_Role_Id",
                        column: x => x.Role_Id,
                        principalTable: "roles",
                        principalColumn: "Role_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    Project_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    State = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Generic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Responsible_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => x.Project_Id);
                    table.ForeignKey(
                        name: "FK_projects_employees_Responsible_Id",
                        column: x => x.Responsible_Id,
                        principalTable: "employees",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employees_projects",
                columns: table => new
                {
                    Employees_Projects_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Project_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees_projects", x => x.Employees_Projects_Id);
                    table.ForeignKey(
                        name: "FK_employees_projects_employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "employees",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_projects_projects_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "projects",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "imputations",
                columns: table => new
                {
                    Imputation_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    Extra_Hours = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Project_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imputations", x => x.Imputation_Id);
                    table.ForeignKey(
                        name: "FK_imputations_employees_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "employees",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_imputations_projects_Project_Id",
                        column: x => x.Project_Id,
                        principalTable: "projects",
                        principalColumn: "Project_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Calendar_Id",
                table: "employees",
                column: "Calendar_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_Role_Id",
                table: "employees",
                column: "Role_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_projects_Employee_Id",
                table: "employees_projects",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_projects_Project_Id",
                table: "employees_projects",
                column: "Project_Id");

            migrationBuilder.CreateIndex(
                name: "IX_imputations_Employee_Id",
                table: "imputations",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_imputations_Project_Id",
                table: "imputations",
                column: "Project_Id");

            migrationBuilder.CreateIndex(
                name: "IX_projects_Responsible_Id",
                table: "projects",
                column: "Responsible_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees_projects");

            migrationBuilder.DropTable(
                name: "imputations");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "calendars");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
