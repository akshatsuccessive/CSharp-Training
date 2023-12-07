using System;
using System.Linq;
using System.Reflection.Metadata;

using var db = new LibraryContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new Book");
db.Add(new Book());
db.SaveChanges();

// Read
Console.WriteLine("Querying for a Book");
var book = db.Books
    .OrderBy(b => b.Title)
    .First();

// Update
//Console.WriteLine("Updating the blog and adding a post");
//Book.BookId = 10;
//Book.Author.(
//    new Author { AuthorId = 101, Name = "Osho" });
//db.SaveChanges();

// Delete
Console.WriteLine("Delete the book");
db.Remove(book);
db.SaveChanges();