using CSProjeDemo1.Entities.Enums;

namespace CSProjeDemo1.Entities.Abstracts
{
    public abstract class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public Status Status { get; set; }
    }
}
