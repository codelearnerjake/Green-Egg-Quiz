using System;
using System.Collections.Generic;
using System.Linq;
using Green_Egg_Quiz.Models;

namespace Green_Egg_Quiz.ViewModels
{
    public class QuizViewModel
    {
        public IEnumerable<QuestionAndAnswers> Questions { get; set; }
    }
}
