using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Strategies
{
    public class SortByTitle : IMangaSortingStrategy
    {
        public IEnumerable<Manga> Sort(IEnumerable<Manga> mangaList)
        {
            return mangaList.OrderBy(manga => manga.Title);
        }
    }
}
