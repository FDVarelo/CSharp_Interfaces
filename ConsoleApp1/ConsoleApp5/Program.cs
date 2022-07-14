using System;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\CSharp_Interfaces\ConsoleApp1\ConsoleApp5\texts\file1.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path)){
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    list.Sort();
                    foreach(string s in list)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}