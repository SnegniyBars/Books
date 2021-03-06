﻿using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.DAL
{
    public class BookRepository : IBookRepository, IDisposable
    {
        private BooksContext context;

        public BookRepository(BooksContext context)
        {
            this.context = context;
        }

        public void DeleteBook(int bookId)
        {
            Book book = context.Books.Find(bookId);
            context.Books.Remove(book);
        }

        public Book GetBookByID(int bookId)
        {
            return context.Books.Find(bookId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return context.Books.ToList();
        }

        public void InsertBook(Book book)
        {
            context.Books.Add(book);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool BookExist(int id)
        {
            return context.Books.Any(e => e.BookId == id);
        }
    }
}
