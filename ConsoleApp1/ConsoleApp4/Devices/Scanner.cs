using System;

namespace ConsoleApp4.Devices
{
    class Scanner : Device, IScanner // Superclasse Device, Interface IScanner.
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}