using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Strategies;
public class MangaSorter
{
    private Dictionary<string, IMangaSortingStrategy> _strategies;

    public MangaSorter()
    {
        _strategies = new Dictionary<string, IMangaSortingStrategy>
        {
            { "title", new SortByTitle() },
            { "author", new SortByAuthor() },
            { "year", new SortByPublicationYear() },
            { "rating", new SortByRating() }
        };
    }

    public IEnumerable<Manga> Sort(string criteria, IEnumerable<Manga> mangaList)
    {
        if (!_strategies.ContainsKey(criteria))
        {
            throw new ArgumentException("Invalid sorting criteria.");
        }

        return _strategies[criteria].Sort(mangaList);
    }
}
