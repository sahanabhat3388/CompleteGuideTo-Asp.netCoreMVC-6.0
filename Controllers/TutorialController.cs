using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.Repository;
using Asp.netCoreMVCIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.Controllers
{
      public class TutorialController : Controller
    {
        private readonly ITutorialRepository _tutorialRepository;
        public TutorialController(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }

        public IActionResult Index()
        {
            var tutorials = _tutorialRepository.GetAllTutorial();
            return View(tutorials);
            
        }

        [HttpGet]
        public IActionResult CreateTutorial()
        {
           return View();

        }

        [HttpPost]
        public IActionResult CreateTutorial(Tutorial tutorial)
        {
            if (!ModelState.IsValid)
            {
                return View(tutorial);
            }
            Tutorial newtutorial = _tutorialRepository.Add(tutorial);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult EditTutorial(int id, string querystringData)
        {
            Tutorial tutorial = _tutorialRepository.GetTutorial(id);
            return View(tutorial);
        }


        [HttpPost]
        public IActionResult EditTutorial(Tutorial modifiedData)
        {

            if (!ModelState.IsValid)
            {
                return View(modifiedData);
            }
            Tutorial tutorial = _tutorialRepository.GetTutorial(modifiedData.Id);
            tutorial.Name = modifiedData.Name;
            tutorial.Description = modifiedData.Description;
            Tutorial updatedTutorial = _tutorialRepository.Update(tutorial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetTutorial(int id)
        {
            Tutorial tutorial = _tutorialRepository.GetTutorial(id);
            // return RedirectToAction("Index",tutorial);
            List<Tutorial> tutorials = new List<Tutorial>();
            tutorials.Add(tutorial);
            return View("Index", tutorials);
        }

        public IActionResult DeleteTutorial(int id)
        {
            Tutorial deletedTutorial = _tutorialRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
