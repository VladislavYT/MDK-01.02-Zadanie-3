using System;


namespace homework
{
    public class Book : IPrintable
    {
        public string name;
        private static List<Book> _books = new List<Book>();

        public Book(string name)
        {
            this.name = name;
            _books.Add(this);
        }

        public void Print()
        {
            Console.WriteLine("Печатаю книгу " + name);
        }

        public static void PrintBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine("Книга " + book.name);
            }
        }
    }
}