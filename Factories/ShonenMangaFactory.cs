// src/MangaDatabaseProject/Factories/ShonenMangaFactory.cs

using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Factories
{
    public class ShonenMangaFactory : IMangaFactory
    {
        public Manga CreateManga(string title, string author, string genre, int publicationYear, float rating)
        {
            return new Manga(title, author, "Shonen", publicationYear, rating);
        }
    }
}
