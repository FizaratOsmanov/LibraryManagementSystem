﻿using LibraryManagementSystem.Enums;
using LibraryManagementSystem.Exceptions;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Concretes;
using System;
/*
//Book book1 = new Book("Book1", 2001)
//{
//    Genre = BookGenreEnum.Science,
//    LibraryLocation = new LibraryLocation(1, 3)
//};
//Book book2 = new Book("Book2", 2002)
//{
//    Genre = BookGenreEnum.NonFiction,
//    LibraryLocation = new LibraryLocation(1, 4)
//};
//Book book3 = new Book("Book3", 2003)
//{
//    Genre = BookGenreEnum.Fiction,
//    LibraryLocation = new LibraryLocation(1, 5)
//};
//Book book4 = new Book("Book4", 2004)
//{
//    Genre = BookGenreEnum.Art,
//    LibraryLocation = new LibraryLocation(1, 6)
//};
//List<Book> books = new List<Book>();

//books.Add(book1);
//books.Add(book2);
//books.Add(book3);
//books.Add(book4);


//LibraryCatalog obj = new LibraryCatalog(books);

//try
//{

//    Console.WriteLine(obj[1].Genre);
//    Console.WriteLine("Proqram davam edir");
//}
//catch (LibraryItemException e)
//{
//    Console.WriteLine($"Error code:-205:{e.Message}");

//}
//catch (Exception e)
//{

//    Console.WriteLine($"Error code:-007:{e.Message}");
//}
//finally
//{
//    Thread.Sleep(1000);
//    Console.WriteLine("Program basa catdi");
//}

//using LibraryManagementSystem.Models;
//using LibraryManagementSystem.Services.Concretes;
//using LibraryManagementSystem.Services.Interfaces;

//ILibrarianService service = new LibrarianService();

//Librarian librarian = new Librarian("Raul")
//{
//    HireDate = DateTime.Now,

//};
//service.CreateLibrarian(librarian);
//try
//{

//    Librarian baseLibrarian = service.GetLibrarianById(1);
//    service.DeleteLibrarian(1, false);
//    Console.WriteLine(baseLibrarian.LibrarianStatus);

//    List<Librarian> librarians = service.GetAllLibrarians();
//    foreach (var item in librarians)
//    {
//        Console.WriteLine(item.Name);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

*/






//Book


BookService bookService = new BookService();

Book book1 = new Book("Book1",1);
bookService.CreateBook(book1);

Book book2 = new Book("Book2", 2);
bookService.CreateBook(book2);

Book book3 = new Book("Book3", 3);
bookService.CreateBook(book3);


List<Book> books = bookService.GetAllBooks();

foreach (Book item in books)
{
    Console.WriteLine(item.Id);
}

try
{
    Book byId = bookService.GetBookById(1);
    Console.WriteLine(byId);
}
catch (Exception)
{
    Console.WriteLine("Bu ID de kitab yoxdur");
}

try
{
    bookService.DeleteBook(1, true);
}
catch (Exception)
{
    Console.WriteLine("Silindi");
}

books= bookService.GetAllBooks();
foreach (Book book in books)
{
    Console.WriteLine(book.Id);
}









//LibraryMember


LibraryMemberService libraryMemberService = new LibraryMemberService();

List<LibraryMember> libraryMembers = new List<LibraryMember>();    
libraryMemberService.CreateLibraryMember(libraryMembers);

List<LibraryMember> libraryMember = libraryMemberService.GetAllLibraryMembers();
foreach (LibraryMember member in libraryMembers)
{
    Console.WriteLine(member);
}

try
{
    LibraryMember byId = libraryMemberService.GetLibraryMemberById(1);
    Console.WriteLine(byId);
}
catch (Exception)
{
    Console.WriteLine("error");
}

try
{
    libraryMemberService.DeleteLibraryMember(1, true);
}
catch (Exception)
{
    Console.WriteLine("error");
}

List<LibraryMember> Members = libraryMemberService.GetAllLibraryMembers();

foreach (LibraryMember Member in Members)
{
    Console.WriteLine(Member);
}