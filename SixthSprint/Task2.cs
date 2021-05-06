using System.Collections;
using System.Collections.Generic;
using System.Linq; 
public class Library : IEnumerable
    {
        public IEnumerable<Book> Books { get; }
        public Predicate<Book> Filter { get; set; } = FindAllBooks;
        public Library(IEnumerable<Book> books)
        {
            Books = books;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new MyEnumerator(Books, Filter);
        }
        private static bool FindAllBooks(Book book)
        {
            return true;
        }
    }
    public sealed class MyEnumerator : IEnumerator<Book>
    {
        public List<Book> _books;
        int pos = -1;
        IEnumerable<Book> _books1 { get; set; }       
        public MyEnumerator(IEnumerable<Book> book, Predicate<Book> filter)
        {
            _books = book.Where(filter.Invoke).ToList();
        }
        public Book Current
        {
            get
            {
                try
                {
                    return _books[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            pos++;
            return (pos < _books.Count);
        }

        public void Reset()
        {
            pos = -1;
        }

    }
    public class MyUtils
    {
        public static List<Book> GetFiltered(IEnumerable<Book> i, Predicate<Book> s)
        {
            Library library = new Library(i) {Filter = s };
            List<Book> list = new List<Book>();
            foreach(var item in library)
            {
                list.Add(item);
            }
            return list;
            
        }
    }
