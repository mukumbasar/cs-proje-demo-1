using CSProjeDemo1.Entities.Abstracts;
using CSProjeDemo1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Concretes.Members
{
    public class Member : IMember
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(string name, string surname, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            BorrowedBooks = new List<Book>();
        }
    }
}
