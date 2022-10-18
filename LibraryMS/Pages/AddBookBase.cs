using System;
using LibraryMS.Data;
using LibraryMS.Models;
using Microsoft.AspNetCore.Components;

namespace AddBookBase
{

    public class AddBookBase : ComponentBase
    {

        public Book Book
        {
            get;
            set;
        } = default!;

        protected override Task OnInitializedAsync()
        {
            Book = new Book();

            return base.OnInitializedAsync();
        }

        public void SaveBook()
        {
            using (LibraryMSDAL dal = new LibraryMSDAL())
            {
                dal.saveBooks(Book);
            }
        }

        public List<Book> GetBooks()
        {
            using (LibraryMSDAL dal = new LibraryMSDAL())
            {
                List<Book> books = dal.getBooks();
                return books;
            }
        }

        public Book GetBookByID(int id)
        {
            using (LibraryMSDAL dal = new LibraryMSDAL())
            {
                Book book = dal.getBookByID(id);
                return book;
            }
        }
    }
}

