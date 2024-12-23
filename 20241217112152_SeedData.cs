using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Commerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixProduit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Code = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "Id", "Code", "Description", "Nom", "PrixProduit" },
                values: new object[,]
                {
                    { 1, 123456789L, "iPhone 14 Pro. Avec un appareil photo principal de 48 MP pour capturer des détails époustouflants. Dynamic Island et l'écran toujours activé, qui offrent une toute nouvelle expérience sur iPhone.", "Iphone 14", 10000m },
                    { 2, 546456789L, "Toutes les fonctions de base, désormais faciles à utiliser. Imprimez, numérisez et copiez les documents quotidiens, et profitez d’une connexion simple et sans fil.", "Imprimante HP Deskjet 2710", 5000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
