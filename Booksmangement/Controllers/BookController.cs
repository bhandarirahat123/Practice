using Booksmangement.Models;
using Booksmangement.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksmangement.Controllers
{
    public class BookController  : Controller
    {
        private readonly Bookrepository bookrepository= null;
        public BookController(Bookrepository book)
        {
            bookrepository = book;
        }
        public ViewResult GettAllBooks()
        {
            var data = bookrepository.GettAllBooks();
            return View(data);
        }
        public ViewResult GettBookbyid(int id)
        {
            var data = bookrepository.GettBookbyid(id);
            return View(data);
        }
        public List<BookModel> SearchBook(String bookname, String authorname)
        {
            return bookrepository.SearchBook(bookname,authorname);
        }

         public ViewResult AddNewBook()
         {
            return View();
         } 
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookmodel)
        {
            return View();
        }
    }
}
