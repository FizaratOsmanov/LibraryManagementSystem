using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Interfaces
{
    public interface IBookService
    {

        Book GetBookById(int id);
        List<Book> GetAllBooks();
        void CreateBook(Book book);
        void DeleteBook(int id, bool IsSoftDelete);
    }
}
