using ArdalanAraghi_HW_14000405_1_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalanAraghi_HW_14000405_1_2.Controllers
{ 
    public class BookController : Controller
    {
        public IActionResult Library()
        {
            return View();
        }
        DBLibrary db = new DBLibrary();
        [HttpGet]
        public List<Book> GetBooks()
        {
            List<Book> books = db.Books.Include(x => x.Author).ToList();
            books.ForEach(x => x.Author.Books = null);
            return books;
        }
        [HttpGet]
        public List<Book> GetBooksBySearchWord(string word)
        {
            var books = db.Books.Where(x => x.Title.Contains(word)).Include(x=>x.Author).ToList();
            books.ForEach(x => x.Author.Books = null);
            return books;
        }
        [HttpGet]
        public List<Author> GetAuthors()
        {
            return db.Authors.ToList();
        }
        [HttpGet]
        public List<Book> GetBooksByAuthorId(int AuthorId)
        {
            var books = db.Books.Where(x => x.AuthorId == AuthorId).ToList();
            return books;
        }
    }
}
