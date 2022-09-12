using System;

namespace homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPrintable[] printables = new IPrintable[] { new Book("первый"), new Magazine("второй"), new Book("третий"), new Magazine("четвертый") };
            foreach (IPrintable printable in printables)
            {
                printable.Print();
            }
            Book.PrintBooks();
            Magazine.PrintMagazine();

            Console.ReadKey();
        }
    }
}