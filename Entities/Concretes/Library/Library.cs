using CSProjeDemo1.Entities.Abstracts;
using CSProjeDemo1.Entities.Concretes.Books;
using CSProjeDemo1.Entities.Concretes.Members;
using CSProjeDemo1.Entities.Enums;
using CSProjeDemo1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Concretes.Library
{
    public class Library
    {   
        public List<IMember> Members { get; set; }
        public List<Book> Books { get; set; }

        public Library() 
        { 
            Books = new List<Book>
            {
                new BookHistory("History of Cars", "Mehmet Celik", new DateTime(2011, 3, 3), "9780062316097"),
                new BookNovel("Drive", "Ahmet Veli", new DateTime(1960, 5, 5), "9780062316092"),
                new BookScience("The Particles of Time", "Michael Tall", new DateTime(1988, 6, 6), "9780062316093")
            };

            Members = new List<IMember>
            {
                new Member("Veli", "Celik", "05555555555"),
                new Member("Demir", "Velioglu", "05555555556")
            };

        }

        // TODO: Implement List Members, List Available Books, List Unavailable Books, List BorrowedBooks of a member

        public void BorrowBook(Guid memberId, Book book)
        {
            var memberToBorrow = Members.FirstOrDefault(m => m.Id == memberId);
            if (memberToBorrow != null)
            {
                memberToBorrow.BorrowedBooks.Add(book);
            }
        }

        public void ReturnBook(Guid memberId, Book book)
        {
            var memberToReturn = Members.FirstOrDefault(m => m.Id == memberId);
            if (memberToReturn != null)
            {
                memberToReturn.BorrowedBooks.Remove(book);
            }
        }


        public void AddBook(string title, string author, string isbn, DateTime publicationDate, BookType bookType)
        {
            switch (bookType)
            {
                case BookType.History:
                    BookHistory bookHistory = new BookHistory(title, author, publicationDate, isbn);
                    Books.Add(bookHistory);
                    break;
                case BookType.Novel:
                    BookNovel bookNovel = new BookNovel(title, author, publicationDate, isbn);
                    Books.Add(bookNovel);
                    break;
                case BookType.Science:
                    BookScience bookScience = new BookScience(title, author, publicationDate, isbn);
                    Books.Add(bookScience);
                    break;
            }
        }

        public void RemoveBook(Guid id)
        {
            var bookToBeRemoved = Books.FirstOrDefault(b => b.Id == id);
            if (bookToBeRemoved != null)
            {
                Books.Remove(bookToBeRemoved);
            }
        }

        public void SignMember(string name, string surname, string phoneNumber)
        {
            Member newMember = new Member(name, surname, phoneNumber);
            Members.Add(newMember);
        }

        public void RemoveMember(string phoneNumber)
        {
            var memberToBeRemoved = Members.FirstOrDefault(m => m.PhoneNumber == phoneNumber);
            if (memberToBeRemoved != null) 
            { 
                Members.Remove(memberToBeRemoved);
            }
        }
    }
}
