using System.Globalization;

namespace ConsoleApp3.Model.Entities
{
    class Rectangle : AbstractShape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height; // Calculo da área de um retangulo.
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}