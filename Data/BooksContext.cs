using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
