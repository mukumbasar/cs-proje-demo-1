using CSProjeDemo1.Entities.Abstracts;
using CSProjeDemo1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Concretes.Books
{
    public class BookNovel : Book
    {
        public BookNovel(string title, string author, DateTime publicationDate, string isbn)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            ISBN = isbn;
            Statue = Status.Available;
        }
    }
}
