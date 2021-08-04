
namespace Green_Egg_Quiz.Models
{
    public class QuestionAndAnswers
    {
        public int Id { get; set; }
        public string Question { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public int CorrectAnswer { get; set; }
    }
}
