using Data.Entities;
using System;
using System.Collections.Generic;

namespace Application.DAL
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByID(int bookId);
        void InsertBook(Book book);
        void DeleteBook(int bookId);
        void UpdateBook(Book book);
        void Save();
        bool BookExist(int id);
    }
}
