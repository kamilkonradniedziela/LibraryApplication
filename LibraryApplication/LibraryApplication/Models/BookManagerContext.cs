using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    public class BookManagerContext : DbContext
    {
        public BookManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }
    }
}
