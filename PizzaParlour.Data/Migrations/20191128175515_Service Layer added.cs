using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaParlour.Data.Migrations
{
    public partial class ServiceLayeradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Depth_DepthId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Size_SizeId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzaId",
                table: "PizzaTopping");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Topping_ToppingId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topping",
                table: "Topping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaTopping",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depth",
                table: "Depth");

            migrationBuilder.RenameTable(
                name: "Topping",
                newName: "Toppings");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "PizzaTopping",
                newName: "PizzaToppings");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Depth",
                newName: "Depths");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaTopping_ToppingId",
                table: "PizzaToppings",
                newName: "IX_PizzaToppings_ToppingId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaTopping_PizzaId",
                table: "PizzaToppings",
                newName: "IX_PizzaToppings_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_SizeId",
                table: "Pizzas",
                newName: "IX_Pizzas_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_DepthId",
                table: "Pizzas",
                newName: "IX_Pizzas_DepthId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaToppings",
                table: "PizzaToppings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depths",
                table: "Depths",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Depths_DepthId",
                table: "Pizzas",
                column: "DepthId",
                principalTable: "Depths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToppings_Pizzas_PizzaId",
                table: "PizzaToppings",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToppings_Toppings_ToppingId",
                table: "PizzaToppings",
                column: "ToppingId",
                principalTable: "Toppings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Depths_DepthId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToppings_Pizzas_PizzaId",
                table: "PizzaToppings");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToppings_Toppings_ToppingId",
                table: "PizzaToppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaToppings",
                table: "PizzaToppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Depths",
                table: "Depths");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "Topping");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "PizzaToppings",
                newName: "PizzaTopping");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "Pizza");

            migrationBuilder.RenameTable(
                name: "Depths",
                newName: "Depth");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaToppings_ToppingId",
                table: "PizzaTopping",
                newName: "IX_PizzaTopping_ToppingId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaToppings_PizzaId",
                table: "PizzaTopping",
                newName: "IX_PizzaTopping_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_SizeId",
                table: "Pizza",
                newName: "IX_Pizza_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_DepthId",
                table: "Pizza",
                newName: "IX_Pizza_DepthId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topping",
                table: "Topping",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaTopping",
                table: "PizzaTopping",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Depth",
                table: "Depth",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Depth_DepthId",
                table: "Pizza",
                column: "DepthId",
                principalTable: "Depth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Size_SizeId",
                table: "Pizza",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzaId",
                table: "PizzaTopping",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Topping_ToppingId",
                table: "PizzaTopping",
                column: "ToppingId",
                principalTable: "Topping",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
