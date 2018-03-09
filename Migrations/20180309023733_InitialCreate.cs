using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace campaignDesignerBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CampaignName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignID);
                });

            migrationBuilder.CreateTable(
                name: "PlotPoints",
                columns: table => new
                {
                    PlotPointID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CampaignID = table.Column<int>(nullable: false),
                    PlotPointDesc = table.Column<string>(nullable: true),
                    isRoot = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlotPoints", x => x.PlotPointID);
                });

            migrationBuilder.CreateTable(
                name: "Transitions",
                columns: table => new
                {
                    TransitionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityType = table.Column<int>(nullable: false),
                    InputID = table.Column<int>(nullable: false),
                    OutputID = table.Column<int>(nullable: false),
                    PlotPointID = table.Column<int>(nullable: true),
                    TransitionSummary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transitions", x => x.TransitionID);
                    table.ForeignKey(
                        name: "FK_Transitions_PlotPoints_PlotPointID",
                        column: x => x.PlotPointID,
                        principalTable: "PlotPoints",
                        principalColumn: "PlotPointID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transitions_PlotPointID",
                table: "Transitions",
                column: "PlotPointID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Transitions");

            migrationBuilder.DropTable(
                name: "PlotPoints");
        }
    }
}
