using Green_Egg_Quiz.Models;
using Green_Egg_Quiz.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;

namespace Green_Egg_Quiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuestionAndAnswerRepository _questionAndAnswerRepository;

        public HomeController(ILogger<HomeController> logger, IQuestionAndAnswerRepository questionAndAnswerRepository)
        {
            _logger = logger;
            _questionAndAnswerRepository = questionAndAnswerRepository;
        }

        public ViewResult Quiz()
        {
            QuizViewModel quizViewModel = new QuizViewModel();

            quizViewModel.Questions = _questionAndAnswerRepository.GetAll;
            return View(quizViewModel);
        }

        [HttpGet]
        [Route("HomeController/GetAnswers")]
        public IActionResult GetAnswers()
        {
            return new JsonResult(_questionAndAnswerRepository.GetAll);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
