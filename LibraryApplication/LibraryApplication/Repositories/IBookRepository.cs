﻿using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Repositories
{
    public interface IBookRepository
    {
        BookModel Get(int bookId);

        IQueryable<BookModel> GetAllActive();

        void Add(BookModel book);

        void Update(int bookId, BookModel book);

        void Delete(int bookId);
    }
}
