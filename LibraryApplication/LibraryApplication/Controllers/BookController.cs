﻿using LibraryApplication.Models;
using LibraryApplication.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Controllers
{
    public class BookController : Controller
    {
        private static IList<BookModel> books = new List<BookModel>()
        {
            new BookModel(){bookID = 1, name="Ksiązka 1", author="Jakiś", dateOfPublication=DateTime.Now, description="Jakiś"}
        };

        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET: BookController
        public ActionResult Index()
        {
            return View(_bookRepository.GetAllActive());
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View(_bookRepository.Get(id));
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View(new BookModel());
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel bookModel)
        {
            _bookRepository.Add(bookModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_bookRepository.Get(id));
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BookModel bookModel)
        {
            _bookRepository.Update(id, bookModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_bookRepository.Get(id));
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BookModel bookModel)
        {
            _bookRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
