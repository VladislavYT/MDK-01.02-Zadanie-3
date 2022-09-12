using System;

namespace homework
{
    public class Drum : IInstrument
    {
        private int size;
        public Drum(int size)
        {
            this.size = size;
        }

        public void Play()
        {
            Console.WriteLine($"Барабан {size}-го размера - играет");
        }
    }
}