// src/MangaDatabaseProject/Observers/ConsoleDatabaseObserver.cs

using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Observers
{
    public class ConsoleDatabaseObserver : IDatabaseObserver
    {
        public void Action(Manga manga, string action, string? change)
        {
            if (change != null)
            {
                System.Console.WriteLine($"The {change} of manga '{manga.Title}' has been {action}.");
            }
            else
            {
            System.Console.WriteLine($"Manga '{manga.Title}' has been {action}.");
            }
        }
    }
}
