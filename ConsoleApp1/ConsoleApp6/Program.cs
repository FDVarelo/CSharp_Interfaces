using System;
using System.Globalization;

using ConsoleApp6.EmployeesFolder;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando interface ICompare:
            //Console.WriteLine("maria".CompareTo("alex")); // → retorna + 1
            //Console.WriteLine("alex".CompareTo("maria")); // → retorna - 1
            //Console.WriteLine("maria".CompareTo("maria")); // → retorna = 0

            // O restanto do código é o mesmo do ConsoleApp5/Program.cs, a única coisa que muda é o path para o file.csv
            string path = @"C:\temp\CSharp_Interfaces\ConsoleApp1\ConsoleApp6\texts\file.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    list.Sort();
                    foreach (string s in list)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

        }
    }
}