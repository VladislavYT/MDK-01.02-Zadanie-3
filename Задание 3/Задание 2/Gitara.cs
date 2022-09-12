using System;

namespace homework
{
    public class Guitar : IInstrument
    {
        private int numberofStrings;

        public Guitar(int numberofStrings)
        {
            this.numberofStrings = numberofStrings;
        }

        public void Play()
        {
            Console.WriteLine($"Гитара с {numberofStrings} струнами - играет");
        }
    }
}