using System;
using ConsoleApp3.Model.Enums;
using ConsoleApp3.Model.Entities;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White }; // Criando circulo com raio 2.0 e cor Branca
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black }; // Criando retangulo preto com largura 3.5 e altura 4.2
            Console.WriteLine(s1 + "\n"); // Printa circulo
            Console.WriteLine(s2); // Printa retangulo
        }
    }
}