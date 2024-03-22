namespace Mission11_Thomas.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
