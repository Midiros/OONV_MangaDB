
using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Strategies
{
    public interface IMangaSortingStrategy
    {
        IEnumerable<Manga> Sort(IEnumerable<Manga> mangaList);
    }
}
