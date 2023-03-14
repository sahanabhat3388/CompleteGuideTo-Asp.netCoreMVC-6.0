using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Models;
using Asp.netCoreMVCIntro.ViewModels;
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

        public void Add(TutorialViewModel tutorial)
        {
            var newTutorial = new Tutorial()
            {
                Description= tutorial.Description,
                Name= tutorial.Name,
            };

            _context.Tutorials.Add(newTutorial);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            Tutorial tutorial = _context.Tutorials.Find(Id);
            if (tutorial != null)
            {
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Tutorial>> GetAllTutorial()
        {
            return await _context.Tutorials.ToListAsync();
        }

        public async Task<Tutorial> GetTutorial(int Id)
        {
            return await _context.Tutorials.FindAsync(Id);
        }

        public Tutorial Update(Tutorial tutorialModified)
        {
            _context.Update(tutorialModified);
            _context.SaveChanges();
            return tutorialModified;
        }
    }
}
