namespace ConsoleApp4.Devices
{
    class ComboDevice : Device, IScanner, IPrinter // Agora funciona, pois temos a superclasse Device, e agora o Scanner e Printer são interface.
    {
        public void Print(string document) // Obrigatorio ter por conta do Device.
        {
            Console.WriteLine("Combodevice print " + document);
        }

        public override void ProcessDoc(string document) // Obrigatorio ter por conta do IPrinter.
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan() // Obrigatorio ter por conta do IScanner.
        {
            return "ComboDevice scan result";
        }
    }
}
