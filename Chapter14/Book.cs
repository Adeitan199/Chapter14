using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set;}
        public string ISBNNum { get; set; }

        List<Book> books = new List<Book>();
        public Book(string title, string author, string publisher, string releasedate, string isbnnum)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releasedate;
            ISBNNum = isbnnum;
        }

        public override string ToString()
        {
            return($"{Title}\t{Author}\t{Publisher}\t{ReleaseDate}\t{ISBNNum}");
        }


        public Book ToBook(string str)
        {
            var bookstr = str.Split("\t");
            var title = bookstr[0];
            var author = bookstr[1];
            var publisher = bookstr[2];
            var releasedate = bookstr[3];
            var isbnnum = bookstr[4];
            return new Book (title, author, publisher, releasedate, isbnnum);
        }
    }
}
