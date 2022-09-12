using System;

namespace homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IInstrument[] instruments = new IInstrument[] { new Drum(3), new Guitar(5), new Trumpet(8) };
            foreach (IInstrument instrument in instruments)
            {
                instrument.Play();
            }

            Console.ReadKey();
        }
    }
}