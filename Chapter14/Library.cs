using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("Enter Book title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Author's name");
            string author = Console.ReadLine();

            Console.WriteLine("Enter publisher's name");
            string publisher = Console.ReadLine();

            Console.WriteLine("Enter release date");
            String releasedate = Console.ReadLine();

            Console.WriteLine("Enter ISBN Number");
            string isbnnum = Console.ReadLine();

            Book book1 = new Book(title, author, publisher, releasedate, isbnnum);
            books.Add(book1);

        }


        public string SearchBook()
        {
            Console.WriteLine("Enter the author;s name");
            string author = Console.ReadLine();

            foreach(var book in books)
            {
                if (author == book.Author)
                {
                    return author;
                }
                else
                {
                    
                }
                
            }
            return null;
        }

        public string InformationAboutBook()
        {
            Console.WriteLine("Enter the title of the book you want to view");
            string title = Console.ReadLine();

            foreach (var book in books)
            {
                if (title == book.Title)
                {
                    Console.WriteLine(book.Title);
                }
                else
                {

                }
            }return null;
        }


        public void Delete()
        {
            Console.WriteLine("Enter the title of the book you want to delete");
             string title = Console.ReadLine();

            foreach (var book in books)
            {
                if (title == book.Title)
                {
                    books.Remove(book);
                }
            }
        }
    }
}
