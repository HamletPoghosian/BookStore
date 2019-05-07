using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.DataBase;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Book> books = new List<Book>();
            using (var db = new AppContextForBook())
            {
                books = db.Books.Select(book => new Book
                {
                    Name = book.Name,
                    Author=book.Author,
                    PublishDate=book.PublishDate,
                    Price=book.Price,
                    Popular=book.Popular
                }).ToList();
                   
                  
            };
                 return View(books);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
