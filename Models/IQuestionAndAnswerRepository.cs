using System.Collections.Generic;

namespace Green_Egg_Quiz.Models
{
    public interface IQuestionAndAnswerRepository
    {
        IEnumerable<QuestionAndAnswers> GetAll { get; }
    }
}