using System;
using Task2;

namespace Client
{
    class Client
    {
        public static void Main(string[] args)
        {
            TVset tv = new TVset();
            Radio radio = new Radio();
            Computer computer = new Computer();
            tv.On();
            radio.On();
            computer.On();
            tv.Off();
            radio.Off();
            computer.Off();
        }
    }
}