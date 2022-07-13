using ConsoleApp3.Model.Enums;

namespace ConsoleApp3.Model.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}