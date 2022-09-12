using System;

namespace homework
{
    public class Trumpet : IInstrument
    {
        private int diameter;

        public Trumpet(int diameter)
        {
            this.diameter = diameter;
        }

        public void Play()
        {
            Console.WriteLine($"Труба с диаметром {diameter}см - играет");
        }
    }
}