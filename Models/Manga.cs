
namespace MangaDatabaseProject.Models
{
    public class Manga
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public float Rating { get; set; }

        public Manga(string title, string author, string genre, int publicationYear, float rating)
        {
            Title = title;
            Author = author;
            Genre = genre;
            PublicationYear = publicationYear;
            Rating = rating;
        }
    }
}
