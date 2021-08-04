using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Green_Egg_Quiz.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<QuestionAndAnswers> QuestionsAndAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Questions

            modelBuilder.Entity<QuestionAndAnswers>().HasData(new QuestionAndAnswers
            {
                Id = 1,
                Question = "What is the tallest mountian on earth?",
                Answer1 = "Mt. Fiji",
                Answer2 = "Mt. Everest",
                Answer3 = "Mt. Olympus",
                CorrectAnswer = 2
            });

            modelBuilder.Entity<QuestionAndAnswers>().HasData(new QuestionAndAnswers
            {
                Id = 2,
                Question = "What is the tallest mountian under the ocean?",
                Answer1 = "Mauna Kea",
                Answer2 = "Monte Pico",
                Answer3 = "Aconcagua",
                CorrectAnswer = 1
            });

            modelBuilder.Entity<QuestionAndAnswers>().HasData(new QuestionAndAnswers
            {
                Id = 3,
                Question = "What is the tallest mountian in the solar system?",
                Answer1 = "Ad Solem on Jupiter",
                Answer2 = "Mt. Everest on Earth",
                Answer3 = "Olympus Mons on Mars",
                CorrectAnswer = 3
            });
        }
    }
}
