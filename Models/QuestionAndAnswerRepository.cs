using System.Collections.Generic;

namespace Green_Egg_Quiz.Models
{
    public class QuestionAndAnswerRepository : IQuestionAndAnswerRepository
    {
        private readonly AppDbContext _appDbContext;

        public QuestionAndAnswerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<QuestionAndAnswers> GetAll
        {

            get
            {
                return _appDbContext.QuestionsAndAnswers;
            }

        }
    }
}
