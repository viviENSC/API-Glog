using Microsoft.EntityFrameworkCore.Migrations;

namespace EnfcGlog.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joueur_Equipe_EquipeId",
                table: "Joueur");

            migrationBuilder.DropIndex(
                name: "IX_Joueur_EquipeId",
                table: "Joueur");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Joueur_EquipeId",
                table: "Joueur",
                column: "EquipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Joueur_Equipe_EquipeId",
                table: "Joueur",
                column: "EquipeId",
                principalTable: "Equipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
