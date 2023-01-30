

using Asp.netCoreMVCIntro.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreMVCIntro.ViewComponents
{
    public class TutorialMenuViewComponent:ViewComponent
    {
        private readonly ITutorialRepository _tutorialRepository;
        public TutorialMenuViewComponent(ITutorialRepository tutorialRepository)
        {
            _tutorialRepository = tutorialRepository;
        }

        //Synchronous method
        public IViewComponentResult Invoke()
        {
            var tutorials = _tutorialRepository.GetAllTutorial().OrderBy(p => p.Name);
            return View(tutorials);
        }
    }
}
