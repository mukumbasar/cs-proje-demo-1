using CSProjeDemo1.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Interfaces
{
    public interface IMember
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public List<Book> BorrowedBooks {  get; set; } 
    }
}
