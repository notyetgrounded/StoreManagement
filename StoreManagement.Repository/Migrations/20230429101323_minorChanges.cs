using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreManagement.Repository.Migrations
{
    /// <inheritdoc />
    public partial class minorChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessEntities_Users_LastModifiedById",
                table: "BusinessEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryModel_Users_LastModifiedById",
                table: "InventoryModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_LastModifiedById",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityRoleAssociations_Users_LastModifiedById",
                table: "SecurityRoleAssociations");

            migrationBuilder.DropIndex(
                name: "IX_SecurityRoleAssociations_LastModifiedById",
                table: "SecurityRoleAssociations");

            migrationBuilder.DropIndex(
                name: "IX_Products_LastModifiedById",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_InventoryModel_LastModifiedById",
                table: "InventoryModel");

            migrationBuilder.DropIndex(
                name: "IX_BusinessEntities_LastModifiedById",
                table: "BusinessEntities");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "SecurityRoleAssociations");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "InventoryModel");

            migrationBuilder.DropColumn(
                name: "LastModifiedById",
                table: "BusinessEntities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedById",
                table: "SecurityRoleAssociations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedById",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedById",
                table: "InventoryModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedById",
                table: "BusinessEntities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SecurityRoleAssociations_LastModifiedById",
                table: "SecurityRoleAssociations",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LastModifiedById",
                table: "Products",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryModel_LastModifiedById",
                table: "InventoryModel",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntities_LastModifiedById",
                table: "BusinessEntities",
                column: "LastModifiedById");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessEntities_Users_LastModifiedById",
                table: "BusinessEntities",
                column: "LastModifiedById",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryModel_Users_LastModifiedById",
                table: "InventoryModel",
                column: "LastModifiedById",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_LastModifiedById",
                table: "Products",
                column: "LastModifiedById",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityRoleAssociations_Users_LastModifiedById",
                table: "SecurityRoleAssociations",
                column: "LastModifiedById",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
