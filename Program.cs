// src/MangaDatabaseProject/Program.cs

using MangaDatabaseProject.Database;
using MangaDatabaseProject.Factories;
using MangaDatabaseProject.Models;
using MangaDatabaseProject.Observers;
using MangaDatabaseProject.Strategies;
using System;

namespace MangaDatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MangaDatabase database = new MangaDatabase();
            IDatabaseObserver consoleObserver = new ConsoleDatabaseObserver();
            database.RegisterObserver(consoleObserver);
            MangaFactory MegaPublisher = new MangaFactory();
            MangaSorter TheSorter = new MangaSorter();
            


            database.AddManga(MegaPublisher.CreateManga("Naruto", "Masashi Kishimoto","shonen", 1999, 9.0f));
            database.AddManga(MegaPublisher.CreateManga("Hunter x Hunter", "Yoshihiro Togashi","shonen", 1997, 9.3f));
            database.AddManga(MegaPublisher.CreateManga("Dragon Ball", "Akira Toriyama","shonen", 1986, 9.0f));
            database.AddManga(MegaPublisher.CreateManga("One Piece", "Eiichiro Oda","shonen", 1999, 9.9f));
            database.AddManga(MegaPublisher.CreateManga("Tokyo Ghoul", "Sui Ishida","seinen", 2006, 8.5f));
            database.AddManga(MegaPublisher.CreateManga("One Punch Man","Murata Yusuke", "seinen", 2012, 8.9f));
            database.AddManga(MegaPublisher.CreateManga("Vagabond","Inoue Takehiko", "seinen", 1998, 10.0f));
            database.AddManga(MegaPublisher.CreateManga("Vinland Saga","Yukimura Makoto","seinen",2005, 9.5f));
            database.AddManga(MegaPublisher.CreateManga("3-gatsu no lion", "Umino Chica","Slice of Life", 2007, 9.5f));
            database.AddManga(MegaPublisher.CreateManga("Beastars","Itagaki Paru","Slice of Life", 2016, 9.1f));
            database.AddManga(MegaPublisher.CreateManga("Oyasumi Punpun","Asano Inio","Slice of Life",2007,10.0f));
            database.AddManga(MegaPublisher.CreateManga("Tensei shitara Slime Datta Ken", "Kawakami Taiki","Isekai",2015,8.0f));
            database.AddManga(MegaPublisher.CreateManga("Mushoku tensei: Isekai Ittara Honki Dasu", "Fujikawa Yuka","Isekai", 2014, 8.5f));
            database.AddManga(MegaPublisher.CreateManga("Ao Haru Ride", "Sakisaka Io","Shoujo",2011,7.0f));
            database.AddManga(MegaPublisher.CreateManga("Orange", "Takano Ichigo","Shoujo",2012,8.0f));
            database.AddManga(MegaPublisher.CreateManga("Grand Blue", "Inoue Kenji","Seinen",2014,10.0f));
            database.AddManga(MegaPublisher.CreateManga("Boruto: Naruto next generations", "Ukyo Kodachi, Masashi Kishimoto","Shonen",2016,5.0f));





            // Console.WriteLine("Sorting by year now --");
            // foreach (var manga in TheSorter.Sort("year", database.mangas))
            // {
            //     Console.WriteLine($"{manga.Title} by {manga.Author} first published in {manga.PublicationYear}");
            // }
            Console.WriteLine("Sorting by rating now --");
            foreach (var manga in TheSorter.Sort("rating", database.mangas))
            {
                Console.WriteLine($"{manga.Title} by {manga.Author} with the average rating of {manga.Rating}");
            }

            // aktualizace zaznamu v databazi
            database.mangas[0].Rating = 9.8f;
            database.UpdateManga(database.mangas[0], "rating");
            database.DeleteManga(database.mangas[0]);
            database.AddManga(MegaPublisher.CreateManga("Berserk", "Hajime Isayama", "seinen", 1989, 10.0f));

            // zniceni observeru
            database.RemoveObserver(consoleObserver);
        }
    }
}
