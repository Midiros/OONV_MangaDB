using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Strategies
{
    public class SortByRating : IMangaSortingStrategy
    {
        public IEnumerable<Manga> Sort(IEnumerable<Manga> mangaList)
        {
            return mangaList.OrderBy(manga => manga.Rating);
        }
    }
}