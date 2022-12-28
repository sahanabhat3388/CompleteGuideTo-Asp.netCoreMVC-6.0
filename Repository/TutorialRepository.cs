using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCIntro.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDbContext _context;
        public TutorialRepository(TutorialDbContext context)
        {
            _context = context;
        }

        public Tutorial Add(Tutorial tutorial)
        {
            _context.Tutorials.Add(tutorial);
            _context.SaveChanges();
            return tutorial;
        }

        public Tutorial Delete(int Id)
        {
            Tutorial tutorial = _context.Tutorials.Find(Id);
            if (tutorial != null)
            {
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges();
            }
            return tutorial;
        }

            public IEnumerable<Tutorial> GetAllTutorial()
        {
            return _context.Tutorials;
        }

        public Tutorial GetTutorial(int Id)
        {
            return _context.Tutorials.Find(Id);
        }

        public Tutorial Update(Tutorial tutorialModified)
        {
            _context.Update(tutorialModified);
            _context.SaveChanges();
            return tutorialModified;
        }
    }
}
