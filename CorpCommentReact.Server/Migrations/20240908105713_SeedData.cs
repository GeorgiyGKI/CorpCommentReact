using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CorpCommentReact.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "BadgeLetter", "Company", "DaysAgo", "Text", "UpvoteCount" },
                values: new object[,]
                {
                    { 1, "B", "ByteGrad", 4, "Hi #ByteGrad, I really like the courses. 😁 I just wish that you would produce more of them and faster. That would be great, as I want to be a dev!", 593 },
                    { 2, "S", "Starbucks", 3, "I really wish #Starbucks would use hand wrappers for hot drinks as a standard, I keep burning my hands and am tired of bothering the employee.", 563 },
                    { 3, "N", "Netflix", 5, "Since yesterday on mobile #netflix keeps buffering the video, it keeps happening even when I redownload the app. I'm in an area with decent internet btw.", 486 },
                    { 4, "M", "McDonald's", 2, "It's a real shame that my local #mcdonald's removed milkshakes from the menu. They were the reason I go to McDonald's. 😩 Please bring them back!", 377 },
                    { 5, "A", "Amazon", 1, "I'm an #amazon prime member but don't really watch the prime video offering. Instead of that I would want an option for even faster delivery 😎", 156 },
                    { 6, "N", "Netflix", 1, "Would be great if #netflix could announce content removals further ahead. 😊 I don't want to get into a show only for it to be gone soon. Thanks.", 88 },
                    { 7, "M", "Microsoft", 1, "I've been using #microsoft teams for a couple of weeks now and one thing that really sticks out is that navigation is too difficult. Please simplify it.", 41 },
                    { 8, "N", "Nike", 5, "Hi #nike I love your running shoes but it's very difficult to return them after a purchase. Had to do a lot of phone calls to make it work. Thanks 👍", 39 },
                    { 9, "M", "McDonald's", 2, "#mcdonald's the past few times I've been some items were missing from my order. Only noticed this when I got home. Straws, nuggets, fries, they missed.", 22 },
                    { 10, "A", "Adidas", 3, "I like your website #adidas, but your sizing guide needs some work. It suggested an L for me but when it arrived it was too big. Still kept it btw 😎", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
