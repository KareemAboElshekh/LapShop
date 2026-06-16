using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    public partial class AddViewItemCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW VwItemCategory
                AS
                SELECT 
                    dbo.TbItems.ItemId, 
                    dbo.TbItems.SalesPrice, 
                    dbo.TbItems.PurchasePrice, 
                    dbo.TbItems.CategoryId, 
                    dbo.TbItems.ImageName, 
                    dbo.TbItems.Gpu, 
                    dbo.TbItems.HardDisk, 
                    dbo.TbItems.ItemTypeId, 
                    dbo.TbItems.Processor, 
                    dbo.TbItems.RamSize, 
                    dbo.TbItems.ScreenReslution, 
                    dbo.TbItems.ScreenSize, 
                    dbo.TbItems.Weight, 
                    dbo.TbItems.OsId, 
                    dbo.TbCategories.CategoryName
                FROM dbo.TbItems 
                INNER JOIN dbo.TbCategories 
                    ON dbo.TbItems.CategoryId = dbo.TbCategories.CategoryId
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF OBJECT_ID('dbo.VwItemCategory', 'V') IS NOT NULL
                    DROP VIEW dbo.VwItemCategory
            ");
        }
    }
}