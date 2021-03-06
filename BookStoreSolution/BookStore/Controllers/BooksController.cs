﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;

using BookStore.Models;
using BookStore.Data;
using BookStore.ViewModel;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {

       
        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        // GET: Books/Details/5
        public ActionResult Details(int Id)
        {
           
            using (var db = new AppContextForBook())
            {
                var book = db.Books.Where(x => x.Id == Id).FirstOrDefault();
                return View(book);
            }
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewBook model)
        {
            try
            {
                using (var db = new AppContextForBook())
                {
                    var book = new Book
                    {
                        Name = model.Name,
                        Author = model.Author,
                        Price = model.Price,
                        Popular = model.Popular,
                        PublishDate = model.PublishDate
                    };
                    try
                    {
                        db.Books.AddRange(book);
                        db.SaveChanges();

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }
        public void AddCart(int Id)
        {
            
            using (var db = new AppContextForBook())
            {
               
                var book = db.Books.Where(x => x.Id == Id).FirstOrDefault();
               
               
            }
           
        }
        public ActionResult Cart()
        {
            return View();
        }
        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}