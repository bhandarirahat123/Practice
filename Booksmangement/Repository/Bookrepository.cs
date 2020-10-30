using Booksmangement.Data;
using Booksmangement.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
namespace Booksmangement.Repository
{
    public class Bookrepository
    {
        private readonly BookStoreContext _context = null;

        public Bookrepository(BookStoreContext context)
        {
            _context = context;

        }

       // public int AddNewBooks(BookModel model)
        //{
         //   var newbook = new Books()
          //  {
            //    Author = model.Author,
              //  Title = model.Title,
                //TotalPages= model.TotalPages,
                //Language=model.Language

            //};
            //_context.Books.Add(newbook);
            //_context.SaveChanges();
            //return 1;
        //}
        public List<BookModel> GettAllBooks()
        {
            return DataSource();
        }
        public BookModel GettBookbyid(int id)
        {
            return DataSource().Where(x => x.ID == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(String title,String authorname)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorname).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ID=1,Title="MVC",Author="Romeo",DESCRIPTION="This is book of MVC Hello dear"},
                new BookModel(){ID=2,Title="Dot netcore",Author="Juliet",DESCRIPTION="This is book of dotnetcore Hello dear please study that"},
                new BookModel(){ID=3,Title="perl",Author="Khan",DESCRIPTION="This is book of perl Hello dear"},
                new BookModel(){ID=4,Title="C#",Author="Romeo",DESCRIPTION="This is book of C#### Hello dear"},
                new BookModel(){ID=5,Title="Java",Author="hehehe",DESCRIPTION="This is book of Java Hello dear"},
            };
        }
    }
}
