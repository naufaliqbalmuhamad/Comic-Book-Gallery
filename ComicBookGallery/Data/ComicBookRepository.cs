using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository //ngebalikin data buku
    {
        private ComicBook[] _ComicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man", //ViewBag untuk mengimpor isi var
                IssueNumber = 700,
                Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist {Role="Script", Name="Dan Slott"},
                    new Artist {Role="Pencils", Name="Humberto Ramos"},
                    new Artist {Role="Inks", Name="Victor Olazaba"},
                    new Artist {Role="Colors", Name="Edgar Delgado"},
                    new Artist {Role="Letters", Name="Chris Eliopoulos"}
                },
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                Description = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                Description = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
            }
        };

        public ComicBook[] GetAllComicBook()
        {
            return _ComicBooks;
        }

        public ComicBook GetComicBook(int Id)
        {
            ComicBook ComicBookReturned = null;

            foreach (var ComicBook in _ComicBooks)
            {
                if (ComicBook.Id == Id)
                {
                    ComicBookReturned = ComicBook;
                }
            }
            return ComicBookReturned;
        }
    }
}