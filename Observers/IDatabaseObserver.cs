// src/MangaDatabaseProject/Observers/IDatabaseObserver.cs

using MangaDatabaseProject.Models;

namespace MangaDatabaseProject.Observers
{
    public interface IDatabaseObserver
    {
        void Action(Manga manga, string action, string? change);
    }
}
