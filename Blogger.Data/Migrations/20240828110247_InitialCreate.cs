using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2909), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2914), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2919), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2921), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2946), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2949), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2957), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2959), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2962), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2964), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3043), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3046), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3051), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3053), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3077), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3079), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3082), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3084), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3088), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3091), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3093), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3095), new DateTime(2024, 8, 28, 14, 2, 47, 219, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 214, DateTimeKind.Local).AddTicks(9531), "AQAAAAEAACcQAAAAEHBL/vs9xhAp044jgPszPxtpAdFEOHbuUEE6WWKlG2t5rJVPmqzvQu78cA8c/wtYrA==", new DateTime(2024, 8, 28, 14, 2, 47, 214, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 216, DateTimeKind.Local).AddTicks(1341), "AQAAAAEAACcQAAAAEACOSM2Hkn/DFx9DyDtFSoKGZ4+JihYb/6WpX4DXQp21/NiXrIIInROrncD+efZi9A==", new DateTime(2024, 8, 28, 14, 2, 47, 216, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 217, DateTimeKind.Local).AddTicks(3085), "AQAAAAEAACcQAAAAEBd9fPyEWSGAiRXwfG092WNXSbrzyxOqAHSYuEhk+/wtJ3Rrp+DvVhW4PWTGglzn8g==", new DateTime(2024, 8, 28, 14, 2, 47, 217, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 2, 47, 218, DateTimeKind.Local).AddTicks(3641), "AQAAAAEAACcQAAAAEKPsGhI4fHyXiOHYCk+bDGRmbCYh7deQS/cq95LEDIPzXNK/3M4zVA+/g/7cUHNZCA==", new DateTime(2024, 8, 28, 14, 2, 47, 218, DateTimeKind.Local).AddTicks(3641) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6563), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6581), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6612), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6618), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6722), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6729), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6734), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6746), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6757), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6762), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6790), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7186), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7194), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7200), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7206), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7213), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7226), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7232), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7239), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7245), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7301), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7309), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7315), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7322), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7333), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7354), new DateTime(2023, 3, 17, 15, 41, 10, 17, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 9, 94, DateTimeKind.Local).AddTicks(5827), "AQAAAAIAAYagAAAAECMT+LfFaspuqH3rPFcY1cdJNl9KDnNIAUyA8PRj285xzgTTII9KTJ9We6gArcsjCg==", new DateTime(2023, 3, 17, 15, 41, 9, 94, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 9, 316, DateTimeKind.Local).AddTicks(1181), "AQAAAAIAAYagAAAAEGwQEUuOvHt1f6fni8zjLcXIpw/+zhM676D5jc6Icq7JYVeohcJgJ3Fdnv+P8S7pCQ==", new DateTime(2023, 3, 17, 15, 41, 9, 316, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 9, 574, DateTimeKind.Local).AddTicks(539), "AQAAAAIAAYagAAAAENqVZfuCj1lTdGD70L7sv5cmPyG65iq4mZKOlHAarOccsBX4bhpkpT2jwFUxDA0wng==", new DateTime(2023, 3, 17, 15, 41, 9, 574, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 17, 15, 41, 9, 768, DateTimeKind.Local).AddTicks(4974), "AQAAAAIAAYagAAAAEJqEXWKJMh/sr3WEgXNaqUZrkqCJL/PzOhggckw9c+NiZNQAjhF8Ap0UafM5stTqGA==", new DateTime(2023, 3, 17, 15, 41, 9, 768, DateTimeKind.Local).AddTicks(4976) });
        }
    }
}
