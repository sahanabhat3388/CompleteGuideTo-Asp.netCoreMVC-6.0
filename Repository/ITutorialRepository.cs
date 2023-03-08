using Asp.netCoreMVCIntro.Models;

namespace Asp.netCoreMVCIntro.Repository
{
    public interface ITutorialRepository
    {
        void Add(Tutorial tutorial);

        Tutorial Update(Tutorial tutorial);

        void Delete(int Id);

        Task<Tutorial> GetTutorial(int Id);

        Task<IEnumerable<Tutorial>> GetAllTutorial();
    }
}
