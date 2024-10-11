using BookStore.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public  BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x=> x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

     

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVCbook", Author = "Nithish" },
                new BookModel() { Id = 2, Title = "C",   Author = "Nithish" },
                new BookModel() { Id = 3, Title = "Java",Author="Monica" },
                new BookModel() { Id = 4, Title = "PHP", Author = "WebGentle" },
                new BookModel() { Id = 5, Title = "PHP", Author = "Webgentle" },

            };
        }
    }
}