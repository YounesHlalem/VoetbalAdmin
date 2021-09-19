using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoetbalAdmin.DAL.Migrations
{
    public partial class InitialDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Geslacht",
                columns: table => new
                {
                    GeslachtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geslacht", x => x.GeslachtId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Seizoen",
                columns: table => new
                {
                    SeizoenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(unicode: false, maxLength: 35, nullable: false),
                    Begindatum = table.Column<DateTime>(nullable: false),
                    Einddatum = table.Column<DateTime>(nullable: true),
                    IsActief = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seizoen", x => x.SeizoenId);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(unicode: false, maxLength: 35, nullable: false),
                    Einddatum = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Reeks",
                columns: table => new
                {
                    ReeksId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(unicode: false, maxLength: 35, nullable: false),
                    SeizoenId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reeks", x => x.ReeksId);
                    table.ForeignKey(
                        name: "FK_Reeks_Seizoen_SeizoenId",
                        column: x => x.SeizoenId,
                        principalTable: "Seizoen",
                        principalColumn: "SeizoenId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Lid",
                columns: table => new
                {
                    LidId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BondsNr = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    TeamId = table.Column<int>(nullable: true),
                    Voornaam = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    Naam = table.Column<string>(unicode: false, maxLength: 35, nullable: false),
                    GeslachtId = table.Column<int>(nullable: false),
                    Geboortedatum = table.Column<DateTime>(nullable: true),
                    Postcode = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    Stad = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Adres = table.Column<string>(unicode: false, maxLength: 70, nullable: false),
                    TelefoonNr = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    IsGearchiveerd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lid", x => x.LidId);
                    table.ForeignKey(
                        name: "FK_Lid_Geslacht_GeslachtId",
                        column: x => x.GeslachtId,
                        principalTable: "Geslacht",
                        principalColumn: "GeslachtId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lid_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Wedstrijd",
                columns: table => new
                {
                    WedstrijdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamThuisId = table.Column<int>(nullable: false),
                    TeamUitId = table.Column<int>(nullable: false),
                    ReeksId = table.Column<int>(nullable: true),
                    Wedstrijddatum = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wedstrijd", x => x.WedstrijdId);
                    table.ForeignKey(
                        name: "FK_Wedstrijd_Reeks_ReeksId",
                        column: x => x.ReeksId,
                        principalTable: "Reeks",
                        principalColumn: "ReeksId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Wedstrijd_Team_TeamThuisId",
                        column: x => x.TeamThuisId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wedstrijd_Team_TeamUitId",
                        column: x => x.TeamUitId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LidRol",
                columns: table => new
                {
                    LidRolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LidId = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false),
                    Begindatum = table.Column<DateTime>(nullable: false),
                    Einddatum = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LidRol", x => x.LidRolId);
                    table.ForeignKey(
                        name: "FK_LidRol_Lid_LidId",
                        column: x => x.LidId,
                        principalTable: "Lid",
                        principalColumn: "LidId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LidRol_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WedstrijdResultaat",
                columns: table => new
                {
                    WedstrijdResultaatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WedstrijdId = table.Column<int>(nullable: false),
                    ScoreThuis = table.Column<int>(nullable: true),
                    ScoreUit = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WedstrijdResultaat", x => x.WedstrijdResultaatId);
                    table.ForeignKey(
                        name: "FK_WedstrijdResultaat_Wedstrijd_WedstrijdId",
                        column: x => x.WedstrijdId,
                        principalTable: "Wedstrijd",
                        principalColumn: "WedstrijdId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Geslacht",
                columns: new[] { "GeslachtId", "Naam" },
                values: new object[,]
                {
                    { 1, "Man" },
                    { 2, "Vrouw" }
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolId", "Naam" },
                values: new object[,]
                {
                    { 1, "Voorzitter" },
                    { 2, "Bestuurslid" },
                    { 3, "Secretaris" },
                    { 4, "Penningmeester" },
                    { 5, "Jeugdcoördinator" },
                    { 6, "Speler" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Geslacht_Naam",
                table: "Geslacht",
                column: "Naam",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lid_BondsNr",
                table: "Lid",
                column: "BondsNr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lid_GeslachtId",
                table: "Lid",
                column: "GeslachtId");

            migrationBuilder.CreateIndex(
                name: "IX_Lid_TeamId",
                table: "Lid",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Lid_BondsNr_TeamId_Voornaam_Naam_GeslachtId_Geboortedatum_Postcode_Stad_Adres_TelefoonNr_IsGearchiveerd",
                table: "Lid",
                columns: new[] { "BondsNr", "TeamId", "Voornaam", "Naam", "GeslachtId", "Geboortedatum", "Postcode", "Stad", "Adres", "TelefoonNr", "IsGearchiveerd" });

            migrationBuilder.CreateIndex(
                name: "IX_LidRol_RolId",
                table: "LidRol",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_LidRol_LidId_RolId_Begindatum_Einddatum",
                table: "LidRol",
                columns: new[] { "LidId", "RolId", "Begindatum", "Einddatum" });

            migrationBuilder.CreateIndex(
                name: "IX_Reeks_Naam",
                table: "Reeks",
                column: "Naam",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reeks_SeizoenId",
                table: "Reeks",
                column: "SeizoenId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Naam",
                table: "Rol",
                column: "Naam",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seizoen_Naam",
                table: "Seizoen",
                column: "Naam",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Team_Naam",
                table: "Team",
                column: "Naam",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wedstrijd_ReeksId",
                table: "Wedstrijd",
                column: "ReeksId");

            migrationBuilder.CreateIndex(
                name: "IX_Wedstrijd_TeamUitId",
                table: "Wedstrijd",
                column: "TeamUitId");

            migrationBuilder.CreateIndex(
                name: "IX_Wedstrijd_TeamThuisId_TeamUitId_Wedstrijddatum_ReeksId",
                table: "Wedstrijd",
                columns: new[] { "TeamThuisId", "TeamUitId", "Wedstrijddatum", "ReeksId" });

            migrationBuilder.CreateIndex(
                name: "IX_WedstrijdResultaat_WedstrijdId",
                table: "WedstrijdResultaat",
                column: "WedstrijdId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WedstrijdResultaat_WedstrijdId_ScoreUit_ScoreThuis",
                table: "WedstrijdResultaat",
                columns: new[] { "WedstrijdId", "ScoreUit", "ScoreThuis" });

            migrationBuilder.Sql(@"CREATE PROCEDURE GetLidById(@Id int) AS BEGIN SELECT * FROM [dbo].[Lid] Where LidId = @Id END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LidRol");

            migrationBuilder.DropTable(
                name: "WedstrijdResultaat");

            migrationBuilder.DropTable(
                name: "Lid");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Wedstrijd");

            migrationBuilder.DropTable(
                name: "Geslacht");

            migrationBuilder.DropTable(
                name: "Reeks");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Seizoen");
        }
    }
}
