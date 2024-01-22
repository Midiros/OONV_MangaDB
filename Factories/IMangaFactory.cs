using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Factories
{
    public interface IMangaFactory
    {
        Manga CreateManga(string title, string author,string genre, int publicationYear, float rating);
    }
}
