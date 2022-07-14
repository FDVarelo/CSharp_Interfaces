using System;

namespace ConsoleApp4.Devices
{
    class Printer : Device, IPrinter // Superclasse Device, Interface IPrinter.
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}