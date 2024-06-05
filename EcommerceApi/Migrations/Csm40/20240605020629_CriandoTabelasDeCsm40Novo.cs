using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApi.Migrations.Csm40
{
    public partial class CriandoTabelasDeCsm40Novo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidoId1",
                table: "PedidoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Produtos_ProdutoId",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.DropIndex(
                name: "IX_PedidoProduto_PedidoId1",
                table: "PedidoProduto");

            migrationBuilder.DropColumn(
                name: "PedidoId1",
                table: "PedidoProduto");

            migrationBuilder.RenameTable(
                name: "PedidoProduto",
                newName: "PedidoProdutos");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_ProdutoId",
                table: "PedidoProdutos",
                newName: "IX_PedidoProdutos_ProdutoId");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "PedidoProdutos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProdutos",
                table: "PedidoProdutos",
                columns: new[] { "PedidoId", "ProdutoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProdutos_Pedidos_PedidoId",
                table: "PedidoProdutos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProdutos_Produtos_ProdutoId",
                table: "PedidoProdutos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProdutos_Pedidos_PedidoId",
                table: "PedidoProdutos");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProdutos_Produtos_ProdutoId",
                table: "PedidoProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProdutos",
                table: "PedidoProdutos");

            migrationBuilder.RenameTable(
                name: "PedidoProdutos",
                newName: "PedidoProduto");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProdutos_ProdutoId",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_ProdutoId");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "PedidoProduto",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId1",
                table: "PedidoProduto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProduto_PedidoId1",
                table: "PedidoProduto",
                column: "PedidoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidoId1",
                table: "PedidoProduto",
                column: "PedidoId1",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Produtos_ProdutoId",
                table: "PedidoProduto",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
