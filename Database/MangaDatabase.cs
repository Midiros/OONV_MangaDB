// src/MangaDatabaseProject/Database/MangaDatabase.cs

using MangaDatabaseProject.Models;
using MangaDatabaseProject.Observers;
using System.Collections.Generic;

namespace MangaDatabaseProject.Database
{
    public class MangaDatabase
    {
        public List<Manga> mangas = new List<Manga>();
        private List<IDatabaseObserver> observers = new List<IDatabaseObserver>();

        public void AddManga(Manga manga)
        {
            mangas.Add(manga);
            NotifyObservers(manga, "added");
        }

        public void UpdateManga(Manga manga, string change)
        {
            NotifyObservers(manga, "updated", change);
        }

        public void DeleteManga(Manga manga)
        {
            mangas.Remove(manga);
            NotifyObservers(manga, "removed");
        }

        public void RegisterObserver(IDatabaseObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IDatabaseObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers(Manga manga, string action, string? change = null)
        {
            foreach (var observer in observers)
            {
                observer.Action(manga, action, change);
            }
        }
    }
}
