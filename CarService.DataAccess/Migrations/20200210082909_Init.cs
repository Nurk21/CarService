using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brakess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrakesCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brakess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabinCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hydraulics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HydraulicCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hydraulics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Undercarriages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UndercarriageCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Undercarriages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyId = table.Column<int>(nullable: false),
                    BrakesId = table.Column<int>(nullable: false),
                    UndercarriageId = table.Column<int>(nullable: false),
                    CabinId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buses_Bodies_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Bodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buses_Brakess_BrakesId",
                        column: x => x.BrakesId,
                        principalTable: "Brakess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buses_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buses_Undercarriages_UndercarriageId",
                        column: x => x.UndercarriageId,
                        principalTable: "Undercarriages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyId = table.Column<int>(nullable: false),
                    BrakesId = table.Column<int>(nullable: false),
                    UndercarriageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Bodies_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Bodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Brakess_BrakesId",
                        column: x => x.BrakesId,
                        principalTable: "Brakess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Undercarriages_UndercarriageId",
                        column: x => x.UndercarriageId,
                        principalTable: "Undercarriages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Truckes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BodyId = table.Column<int>(nullable: false),
                    BrakesId = table.Column<int>(nullable: false),
                    UndercarriageId = table.Column<int>(nullable: false),
                    HydraulicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truckes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Truckes_Bodies_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Bodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Truckes_Brakess_BrakesId",
                        column: x => x.BrakesId,
                        principalTable: "Brakess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Truckes_Hydraulics_Id",
                        column: x => x.Id,
                        principalTable: "Hydraulics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Truckes_Undercarriages_UndercarriageId",
                        column: x => x.UndercarriageId,
                        principalTable: "Undercarriages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Handrails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HandrailCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handrails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Handrails_Buses_Id",
                        column: x => x.Id,
                        principalTable: "Buses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wheels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WheelCondition = table.Column<byte>(nullable: false),
                    RepairPrice = table.Column<double>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    BusId = table.Column<int>(nullable: false),
                    TruckId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheels_Buses_BusId",
                        column: x => x.BusId,
                        principalTable: "Buses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Wheels_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Wheels_Truckes_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truckes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buses_BodyId",
                table: "Buses",
                column: "BodyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buses_BrakesId",
                table: "Buses",
                column: "BrakesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buses_CabinId",
                table: "Buses",
                column: "CabinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Buses_UndercarriageId",
                table: "Buses",
                column: "UndercarriageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BodyId",
                table: "Cars",
                column: "BodyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrakesId",
                table: "Cars",
                column: "BrakesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UndercarriageId",
                table: "Cars",
                column: "UndercarriageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Truckes_BodyId",
                table: "Truckes",
                column: "BodyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Truckes_BrakesId",
                table: "Truckes",
                column: "BrakesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Truckes_UndercarriageId",
                table: "Truckes",
                column: "UndercarriageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_BusId",
                table: "Wheels",
                column: "BusId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_CarId",
                table: "Wheels",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_TruckId",
                table: "Wheels",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Handrails");

            migrationBuilder.DropTable(
                name: "Wheels");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Truckes");

            migrationBuilder.DropTable(
                name: "Cabins");

            migrationBuilder.DropTable(
                name: "Bodies");

            migrationBuilder.DropTable(
                name: "Brakess");

            migrationBuilder.DropTable(
                name: "Hydraulics");

            migrationBuilder.DropTable(
                name: "Undercarriages");
        }
    }
}
