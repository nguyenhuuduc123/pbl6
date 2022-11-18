using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApp.API.Migrations
{
    public partial class D2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "varchar(256)",
                maxLength: 256,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomTypeId",
                table: "RoomType",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RoomType",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "RoomType",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "NumAdult",
                table: "RoomType",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NumChildren",
                table: "RoomType",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Quantity",
                table: "RoomType",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomTypeId",
                table: "Rooms",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId",
                table: "Rooms",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomTypeId1",
                table: "Rooms",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType",
                column: "RoomTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "RoomId");

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Remain = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Reduction = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "payment",
                columns: table => new
                {
                    Payment_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Payment_type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment", x => x.Payment_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Promotion_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date_start = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Date_end = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Discount_Rate = table.Column<int>(type: "int", nullable: false),
                    Is_Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Promotion_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Promotion_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataUrl = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    room_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomImages_Rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Create = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckOut = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RoomAmount = table.Column<int>(type: "int", nullable: false),
                    Canceled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CouponId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Coupon_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Coupons_Coupon_Id",
                        column: x => x.Coupon_Id,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Promotion_Apply",
                columns: table => new
                {
                    Promotion_Apply_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Promotion_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    room_type_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_Apply", x => x.Promotion_Apply_Id);
                    table.ForeignKey(
                        name: "FK_Promotion_Apply_Promotions_Promotion_id",
                        column: x => x.Promotion_id,
                        principalTable: "Promotions",
                        principalColumn: "Promotion_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Promotion_Apply_RoomType_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BookingsDetails",
                columns: table => new
                {
                    BookingDetailId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoomQuantity = table.Column<float>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Price = table.Column<float>(type: "float", nullable: false),
                    roomTypeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookingId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingsDetails", x => x.BookingDetailId);
                    table.ForeignKey(
                        name: "FK_BookingsDetails_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingsDetails_RoomType_roomTypeId",
                        column: x => x.roomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payment_Detail",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Total_Price = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Paydet_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Payment_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    bookingDetailId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Detail", x => x.id);
                    table.ForeignKey(
                        name: "FK_Payment_Detail_BookingsDetails_bookingDetailId",
                        column: x => x.bookingDetailId,
                        principalTable: "BookingsDetails",
                        principalColumn: "BookingDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Detail_payment_Payment_id",
                        column: x => x.Payment_id,
                        principalTable: "payment",
                        principalColumn: "Payment_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PaymentDetailId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookingDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Payment_Detail_PaymentDetailId",
                        column: x => x.PaymentDetailId,
                        principalTable: "Payment_Detail",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId1",
                table: "Rooms",
                column: "RoomTypeId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Coupon_Id",
                table: "Bookings",
                column: "Coupon_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingsDetails_BookingId",
                table: "BookingsDetails",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingsDetails_roomTypeId",
                table: "BookingsDetails",
                column: "roomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_History_PaymentDetailId",
                table: "History",
                column: "PaymentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Detail_bookingDetailId",
                table: "Payment_Detail",
                column: "bookingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Detail_Payment_id",
                table: "Payment_Detail",
                column: "Payment_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Apply_Promotion_id",
                table: "Promotion_Apply",
                column: "Promotion_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Apply_room_type_id",
                table: "Promotion_Apply",
                column: "room_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_room_id",
                table: "RoomImages",
                column: "room_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId1",
                table: "Rooms",
                column: "RoomTypeId1",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId1",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Promotion_Apply");

            migrationBuilder.DropTable(
                name: "RoomImages");

            migrationBuilder.DropTable(
                name: "Payment_Detail");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "BookingsDetails");

            migrationBuilder.DropTable(
                name: "payment");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeId1",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "NumAdult",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "NumChildren",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RoomType");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomTypeId1",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RoomType",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RoomTypeId",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
