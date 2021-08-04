using Microsoft.EntityFrameworkCore.Migrations;

namespace Green_Egg_Quiz.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionsAndAnswers",
                columns: new[] { "Id", "Answer1", "Answer2", "Answer3", "CorrectAnswer", "Question" },
                values: new object[] { 1, "Mt. Fiji", "Mt. Everest", "Mt. Olympus", 2, "What is the tallest mountian on earth?" });

            migrationBuilder.InsertData(
                table: "QuestionsAndAnswers",
                columns: new[] { "Id", "Answer1", "Answer2", "Answer3", "CorrectAnswer", "Question" },
                values: new object[] { 2, "Mauna Kea", "Monte Pico", "Aconcagua", 1, "What is the tallest mountian under the ocean?" });

            migrationBuilder.InsertData(
                table: "QuestionsAndAnswers",
                columns: new[] { "Id", "Answer1", "Answer2", "Answer3", "CorrectAnswer", "Question" },
                values: new object[] { 3, "Ad Solem on Jupiter", "Mt. Everest on Earth", "Olympus Mons on Mars", 3, "What is the tallest mountian in the solar system?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionsAndAnswers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionsAndAnswers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionsAndAnswers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
