using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeModel_Users_UserId",
                table: "EmployeeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryModel_BusinessEntities_BusinessEntityId",
                table: "InventoryModel");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryModel_Products_ProductId",
                table: "InventoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryModel",
                table: "InventoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeModel",
                table: "EmployeeModel");

            migrationBuilder.RenameTable(
                name: "InventoryModel",
                newName: "Inventories");

            migrationBuilder.RenameTable(
                name: "EmployeeModel",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryModel_ProductId",
                table: "Inventories",
                newName: "IX_Inventories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryModel_BusinessEntityId",
                table: "Inventories",
                newName: "IX_Inventories_BusinessEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeModel_UserId",
                table: "Employees",
                newName: "IX_Employees_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.CreateTable(
                name: "LinkedBusinessEntities",
                columns: table => new
                {
                    LinkedBusinessEntitesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentBusinessEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildBusinessEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedReason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkedBusinessEntities", x => x.LinkedBusinessEntitesId);
                    table.ForeignKey(
                        name: "FK_LinkedBusinessEntities_BusinessEntities_ChildBusinessEntityId",
                        column: x => x.ChildBusinessEntityId,
                        principalTable: "BusinessEntities",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LinkedBusinessEntities_BusinessEntities_ParentBusinessEntityId",
                        column: x => x.ParentBusinessEntityId,
                        principalTable: "BusinessEntities",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Name",
                table: "Inventories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LinkedBusinessEntities_ChildBusinessEntityId",
                table: "LinkedBusinessEntities",
                column: "ChildBusinessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_LinkedBusinessEntities_ParentBusinessEntityId",
                table: "LinkedBusinessEntities",
                column: "ParentBusinessEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_BusinessEntities_BusinessEntityId",
                table: "Inventories",
                column: "BusinessEntityId",
                principalTable: "BusinessEntities",
                principalColumn: "BusinessEntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_BusinessEntities_BusinessEntityId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories");

            migrationBuilder.DropTable(
                name: "LinkedBusinessEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_Name",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "InventoryModel");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeModel");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_ProductId",
                table: "InventoryModel",
                newName: "IX_InventoryModel_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Inventories_BusinessEntityId",
                table: "InventoryModel",
                newName: "IX_InventoryModel_BusinessEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_UserId",
                table: "EmployeeModel",
                newName: "IX_EmployeeModel_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryModel",
                table: "InventoryModel",
                column: "InventoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeModel",
                table: "EmployeeModel",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeModel_Users_UserId",
                table: "EmployeeModel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryModel_BusinessEntities_BusinessEntityId",
                table: "InventoryModel",
                column: "BusinessEntityId",
                principalTable: "BusinessEntities",
                principalColumn: "BusinessEntityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryModel_Products_ProductId",
                table: "InventoryModel",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
