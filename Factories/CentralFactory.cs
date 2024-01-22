using MangaDatabaseProject.Factories;
using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Factories;
public class MangaFactory
{
    public Manga CreateManga(string title, string author, string genre, int publicationYear, float rating)
    {
        IMangaFactory factory = GetFactory(genre);
        return factory.CreateManga(title, author,genre, publicationYear, rating);
    }

    private IMangaFactory GetFactory(string genre)
    {
        switch (genre.ToLower())
        {
            case "shonen":
                return new ShonenMangaFactory();
            case "shoujo":
                return new ShojoMangaFactory();
            case "isekai":
                return new IsekaiMangaFactory();
            case "seinen":
                return new SeinenMangaFactory();
            case "slice of life":
                return new SoLMangaFactory();
            default:
                throw new ArgumentException("We cannot create a manga of this genre.");
        }
    }
}
