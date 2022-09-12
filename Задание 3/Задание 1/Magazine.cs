using System;


namespace homework
{
    public class Magazine : IPrintable
    {
        public string name;
        private static List<Magazine> _magazines = new List<Magazine>();

        public Magazine(string name)
        {
            this.name = name;
            _magazines.Add(this);
        }

        public void Print()
        {
            Console.WriteLine("Печатаю журнал " + name);
        }

        public static void PrintMagazine()
        {
            foreach (Magazine magazine in _magazines)
            {
                Console.WriteLine("Журнал " + magazine.name);
            }
        }
    }
}