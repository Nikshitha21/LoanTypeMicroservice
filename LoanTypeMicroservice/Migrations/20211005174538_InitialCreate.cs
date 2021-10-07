using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanTypeMicroservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplyLoans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanAmount = table.Column<long>(type: "bigint", nullable: false),
                    LoanApplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RateOfIntrest = table.Column<int>(type: "int", nullable: false),
                    LoanDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyLoans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLoans",
                columns: table => new
                {
                    CustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseFee = table.Column<int>(type: "int", nullable: false),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    CurCompanyExp = table.Column<int>(type: "int", nullable: false),
                    RationCardNo = table.Column<long>(type: "bigint", nullable: false),
                    AnnualIncome = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLoans", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "PersonalLoans",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnualIncome = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalExp = table.Column<int>(type: "int", nullable: false),
                    CurCompanyExp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalLoans", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyLoans");

            migrationBuilder.DropTable(
                name: "EducationLoans");

            migrationBuilder.DropTable(
                name: "PersonalLoans");
        }
    }
}
