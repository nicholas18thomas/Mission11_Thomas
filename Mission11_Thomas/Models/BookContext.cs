﻿using Microsoft.EntityFrameworkCore;

namespace Mission11_Thomas.Models
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set;}
    }
}
