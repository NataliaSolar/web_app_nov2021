using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Data.Migrations
{
    public partial class AddAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchasedBookBookId",
                table: "PurchaseEvent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseEvent_PurchasedBookBookId",
                table: "PurchaseEvent",
                column: "PurchasedBookBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseEvent_Book_PurchasedBookBookId",
                table: "PurchaseEvent",
                column: "PurchasedBookBookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseEvent_Book_PurchasedBookBookId",
                table: "PurchaseEvent");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseEvent_PurchasedBookBookId",
                table: "PurchaseEvent");

            migrationBuilder.DropColumn(
                name: "PurchasedBookBookId",
                table: "PurchaseEvent");
        }
    }
}
