using System;
using LibraryMS.Models;

namespace LibraryMS.Data
{
    public class LibraryMSDAL : IDisposable
    {
        public void Dispose()
        {

        }

        public void saveBooks(Book Book)
        {
            using (LibraryMSDBContext ctx = new LibraryMSDBContext())
            {
                ctx.Books.Add(Book);
                ctx.SaveChanges();
            }
        }

        public List<Book> getBooks()
        {
            using (LibraryMSDBContext ctx = new LibraryMSDBContext())
            {
                return ctx.Books.ToList();
            }
        }

        public Book getItemByID(int id)
        {
            using (LibraryMSDBContext ctx = new LibraryMSDBContext())
            {
                return ctx.Books.Where(book => book.Id == id).First();

            }

        }

        public LibraryMSDAL()
        {
        }
    }
}

