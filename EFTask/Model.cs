using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class LibraryContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    public string DbPath { get; }

    public LibraryContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "library.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

/*
public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}

*/

public class Book
{
    static public int BookId { get; set; }
    public string Title { get; set; } = "";
    public int AuthorId { get; set; }
    public bool IsIssued { get; set; }
    static public Author Author { get; set; } = new();
}

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; } = "";
    //public ICollection<Book> Books { get; } = new List<Book>();
}

public class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; } = "";
    public ICollection<Book> IssuedBooks { get; } = new List<Book>();
}